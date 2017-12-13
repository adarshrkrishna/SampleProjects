using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Assignment : ContentPage
    {
        ObservableCollection<Persons> oc = new ObservableCollection<Persons>();

        public Assignment()
        {
            InitializeComponent();
            oc.Add(new Persons() { Name = "Ravi", CompanyName = "Dell" });
            oc.Add(new Persons() { Name = "Dhershan", CompanyName = "Tcs" });
            oc.Add(new Persons() { Name = "Rahul", CompanyName = "Hp" });
            oc.Add(new Persons() { Name = "Sandeep", CompanyName = "Microsoft" });
            oc.Add(new Persons() { Name = "Ajith", CompanyName = "MindTree" });
            oc.Add(new Persons() { Name = "Jinto", CompanyName = "Google" });
            oc.Add(new Persons() { Name = "Sneha", CompanyName = "Wipro" });
            asgnrem.ItemsSource = oc;
        }

        async void OnRemove(Object sender, EventArgs e)
        {
            var item = sender as Button;
            var listItem = (from a in oc where a.Name == item.CommandParameter.ToString() select a).FirstOrDefault<Persons>();
            await DisplayAlert("Alert", "Remove " + item.CommandParameter, "Ok", "cancel");
            oc.Remove(listItem);
            await DisplayAlert(" ", "Removed" , "Ok");
        }
    }

    public class Persons
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
    }
}