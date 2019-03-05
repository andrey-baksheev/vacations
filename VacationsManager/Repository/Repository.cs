using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacationsLib.Model;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;

namespace VacationsManager.Repository
{
    public class Repository: IWebVacation
    {
        private String baseAddress;
        private Uri baseUri;
        private HttpClient httpClient;

        public Repository(String baseAddress)
        {
            this.baseAddress = baseAddress;
            this.baseUri = new Uri(this.baseAddress);

            httpClient = new HttpClient();
            httpClient.BaseAddress = baseUri;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void CreateEmployee(String fullname)
        {
            throw new NotImplementedException();
        }

        public void CreateVacation(DateTime startDate, Int16 duration)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Int32 employeeId)
        {
            throw new NotImplementedException();
        }

        public void DeleteVacation(Int32 vacationId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> SelectAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            /*Stream stream = SelectAllEmployees("http://localhost:51650/api/vacations").Result;
            employees = Deserialize<List<Employee>>(stream);
            return employees;*/


            HttpWebRequest request = WebRequest.Create("http://localhost:51650/api/vacations") as HttpWebRequest;
            request.ContentType = "application/json";
            request.Method = "GET";
            request.ContentLength = 0;
            String responseData = String.Empty;

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    responseData = reader.ReadToEnd();

                    using (BufferedStream stream = new BufferedStream(response.GetResponseStream()))
                    {
                        stream.Position = 0;
                        employees = Deserialize<IEnumerable<Employee>>(stream).ToList();
                    }

                    reader.Close();
                }

                
                //response.Close();
            }

            return employees;
        }

        async Task<Stream> SelectAllEmployees(String path)
        {
            Stream stream = Stream.Null;
            HttpResponseMessage response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                stream = await response.Content.ReadAsStreamAsync();
            }
            return stream;
        }          

        /*private Object DeserializeFromStream(Stream stream)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                return serializer.Deserialize(jsonTextReader);
            }
        }*/

        private T Deserialize<T>(Stream s)
        {
            using (StreamReader reader = new StreamReader(s))
            {
                using (JsonTextReader jsonReader = new JsonTextReader(reader))
                {
                    JsonSerializer ser = new JsonSerializer();
                    return ser.Deserialize<T>(jsonReader);
                }
            }
        }

    }
}
