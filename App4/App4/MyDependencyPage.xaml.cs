using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyDependencyPage : ContentPage
    {
        public MyDependencyPage()
        {
            InitializeComponent();

             string msg = DependencyService.Get<IMyDependency>().GetMessage();
             myLabel.Text = msg;
        }
    }
}