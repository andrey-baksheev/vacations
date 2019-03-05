using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Net.Http;
using VacationsManager.Dialogs;
using VacationsManager.Repository;


namespace VacationsManager
{
    public partial class MainWindow : Window
    {
        private static IWebVacation repository = new Repository.Repository("http://localhost:51650/api");

        private void newEmployee_Click(object sender, RoutedEventArgs e)
        {
            NewEmployee employeeDialog = new NewEmployee();
            employeeDialog.ShowDialog();
        }

        private void newVacation_Click(object sender, RoutedEventArgs e)
        {
            NewVacation vacationDialog = new NewVacation();
            vacationDialog.ShowDialog();
        }

        private async void selectButton_Click(object sender, RoutedEventArgs e)
        {
            /*var vacationReport = (from r in reports
                                  group r by r.EmployeeId into q
                                  select new
                                  {
                                      Name = q.Key,
                                      Count = q.Count()
                                  });
            this.vacationsReportGrid.ItemsSource = vacationReport;*/
            this.vacationsReportGrid.ItemsSource = repository.SelectAllEmployees();
         }

    }
}