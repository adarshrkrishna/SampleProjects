using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView1 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>(); 
        public ListView1()
        {
            InitializeComponent();
            employees.Add(new Employee() { DisplayName = "RAVI", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "DHERSHAN", DisplayDetail = "9945623644" });
            employees.Add(new Employee() { DisplayName = "PAMB", DisplayDetail = "9945488154" });
            employees.Add(new Employee() { DisplayName = "ADARSH R KRISHNA", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "ANU", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "NEELAMMA", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "MAUTHAMMA", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "RAHUL", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "SANDEEP", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "JINTO", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "AJITH", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "ASWANTH", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "HARSHA", DisplayDetail = "9945623154" });
            employees.Add(new Employee() { DisplayName = "SNEHA", DisplayDetail = "9945623154" });
            EmployeeView.ItemsSource = employees;
        }
    }

    public class Employee
    {
        public string DisplayName { get; set; }
        public string DisplayDetail { get; set; }
    }
}