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
    public partial class ScrollView1 : ContentPage
    {
        public ScrollView1()
        {
            InitializeComponent();
        }

        async void OnBackButton(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}