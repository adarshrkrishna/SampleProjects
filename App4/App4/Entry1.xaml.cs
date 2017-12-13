using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry1 : ContentPage
    {
        public Entry1()
        {
            InitializeComponent();
        }

        void OnEntry(Object sender, EventArgs e)
        {
            var obj = (Entry)sender;
            var txt = obj.Text;
            DisplayAlert("Text", txt, "Ok");
        }
    }
}