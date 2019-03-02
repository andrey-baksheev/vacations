using System;
using VacationsLib.Model;


namespace VacationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (VacationsContext context = new VacationsContext())
                { 
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
