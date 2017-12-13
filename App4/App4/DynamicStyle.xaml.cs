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
    public partial class DynamicStyle : ContentPage
    {
        bool OnOrginalStyle = true;

        public DynamicStyle()
        {
            InitializeComponent();
            Resources["BsearchBarStyle"] = Resources["blueSearchBarStyle"];
            Resources["TsearchBarStyle"] = Resources["tealSearchBarStyle"];
        }

        void OnButton(Object sender, EventArgs e)
        {
            if(OnOrginalStyle)
            {
                Resources["BsearchBarStyle"] = Resources["tealSearchBarStyle"];
                Resources["TsearchBarStyle"] = Resources["blueSearchBarStyle"];
                OnOrginalStyle = false;
            }
            else
            {
                Resources["BsearchBarStyle"] = Resources["blueSearchBarStyle"];
                Resources["TsearchBarStyle"] = Resources["tealSearchBarStyle"];
                OnOrginalStyle = true;
            }
        }
    }
}