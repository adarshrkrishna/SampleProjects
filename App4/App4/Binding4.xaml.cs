using App4.Models;
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
	public partial class Binding4 : ContentPage
	{
		public Binding4 ()
		{
            Student s = new Student();
            s.StudentName = "Kundhan";
            BindingContext = s;
            InitializeComponent ();
		}
	}
}