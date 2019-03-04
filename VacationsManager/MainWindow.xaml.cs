using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using VacationsLib.Model;
using System.IO;

namespace VacationsManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddressService);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.client.Dispose();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
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
                    reader.Close();
                }

                response.Close();
            }

            MessageBox.Show(responseData);
        }
    }
}
