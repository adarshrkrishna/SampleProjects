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
	public partial class Image1 : ContentPage
	{
        ObservableCollection<Imagec> img = new ObservableCollection<Imagec>();

        public Image1 ()
		{
			InitializeComponent ();
            img.Add(new Imagec { Src = "http://freedesignfile.com/upload/2013/07/fresh_fruits_05.jpg", Name = "Apple", FruitDetails = "$5" });
            img.Add(new Imagec { Src = "http://www.greatgrubclub.com/domains/greatgrubclub.com/local/media/images/medium/4_1_1_orange.jpg", Name = "Orange", FruitDetails = "$6" });
            img.Add(new Imagec { Src = "https://thumb9.shutterstock.com/display_pic_with_logo/676765/515237146/stock-photo-strawberry-isolated-on-white-background-clipping-path-515237146.jpg", Name = "StrawBerry", FruitDetails = "$8" });
            img.Add(new Imagec { Src = "http://www.runners2life.com/wp-content/uploads/2017/07/freeze-bananas-ate-x.jpg", Name = "Banana", FruitDetails = "$2" });
            img.Add(new Imagec { Src = "http://www.diabetes.co.uk/blog/wp-content/uploads/2015/09/Grape-White-Background-Vine-Fruit-Bunch_Medium.jpg", Name = "Grapes", FruitDetails = "$1" });
            img.Add(new Imagec { Src = "https://www.organicfacts.net/wp-content/uploads/2013/06/Pineapple.jpg", Name = "PineApple", FruitDetails = "$10" });
            img.Add(new Imagec { Src = "http://cdn.akc.org/content/article-body-image/mango.jpg", Name = "Mango", FruitDetails = "$15" });
            img.Add(new Imagec { Src = "http://img-aws.ehowcdn.com/350x235p/photos.demandstudios.com/getty/article/111/114/skd287314sdc_XS.jpg", Name = "WaterMelon", FruitDetails = "$4" });
            imageList.ItemsSource = img;
        }

        void OnSelection(Object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null )
            {
                return;
            }
            DisplayAlert("Selected", "Fruit", "Ok");
        }
	}

    public class Imagec
    {
        public string Src { get; set; }
        public string Name { get; set; }
        public string FruitDetails { get; set; }
    }
}