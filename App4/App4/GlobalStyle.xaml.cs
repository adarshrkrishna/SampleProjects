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
    public partial class GlobalStyle : ContentPage
    {
        public GlobalStyle()
        {
            InitializeComponent();
        }

        void OnButton1(Object sender, EventArgs e)
        {
            var item = (Button)sender;
            item.BackgroundColor = Color.Lime;
            if (buttonThree.BackgroundColor == Color.Lime)
            {
                buttonThree.BackgroundColor = Color.Default;
            }
            if (buttonTwo.BackgroundColor == Color.Lime)
            {
                buttonTwo.BackgroundColor = Color.Default;
            }
        }

        void OnButton2(Object sender, EventArgs e)
        {
            buttonTwo.BackgroundColor = Color.Lime;
            if (buttonOne.BackgroundColor == Color.Lime)
            {
                buttonOne.BackgroundColor = Color.Default;
            }
            if(buttonThree.BackgroundColor == Color.Lime)
            {
                buttonThree.BackgroundColor = Color.Default;
            }
        }

        void OnButton3(Object sender, EventArgs e)
        {
            buttonThree.BackgroundColor = Color.Lime;
            if (buttonOne.BackgroundColor == Color.Lime)
            {
                buttonOne.BackgroundColor = Color.Default;
            }
            if (buttonTwo.BackgroundColor == Color.Lime)
            {
                buttonTwo.BackgroundColor = Color.Default;
            }
        }
    }
}