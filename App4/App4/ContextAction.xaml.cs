using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContextAction : ContentPage
    {
        ObservableCollection<Prsn> oc = new ObservableCollection<Prsn>();

        public ContextAction()
        {
            InitializeComponent();
            oc.Add(new Prsn() { Name = "Ravi", CompanyName = "Dell" });
            oc.Add(new Prsn() { Name = "Dhershan", CompanyName = "Tcs" });
            oc.Add(new Prsn() { Name = "Rahul", CompanyName = "Hp" });
            oc.Add(new Prsn() { Name = "Sandeep", CompanyName = "Microsoft" });
            oc.Add(new Prsn() { Name = "Ajith", CompanyName = "MindTree" });
            oc.Add(new Prsn() { Name = "Jinto", CompanyName = "Google" });
            oc.Add(new Prsn() { Name = "Sneha", CompanyName = "Wipro" });
            oc.Add(new Prsn() { Name = "Harsha", CompanyName = "Tcs" });
            oc.Add(new Prsn() { Name = "Kelan", CompanyName = "Mercedez" });
            oc.Add(new Prsn() { Name = "Jubil", CompanyName = "Bmw" });
            contxt.ItemsSource = oc;
        }
        async void  OnDelete(Object sender, EventArgs e)
        {
            var fn = (MenuItem)sender;
            bool action = await DisplayAlert("Delete", fn.CommandParameter.ToString(), "Ok","Cancel");
            Debug.WriteLine("the selected answer is " + action);

            if (action)
            {
                Prsn deleteItem = (from a in oc where a.Name == fn.CommandParameter.ToString() select a).FirstOrDefault<Prsn>();
                oc.Remove(deleteItem);
                await DisplayAlert(" ", "Deleted", "Ok");
            }
        }
    }

    public class Prsn
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
    }
}