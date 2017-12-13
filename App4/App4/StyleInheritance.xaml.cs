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
    public partial class StyleInheritance : ContentPage
    {
        bool labelSelected = true;

        public StyleInheritance()
        {
            InitializeComponent();
        }

        void OnButton(Object sender, EventArgs e)
        {
            if (labelSelected)
            {
                label.BackgroundColor = Color.Pink;
                labelSelected = false;
            }
            else
            {
                label.BackgroundColor = Color.Default;
                labelSelected = true;
            }
        }
    }
}