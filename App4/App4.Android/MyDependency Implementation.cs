using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using App4.Droid;

[assembly: Dependency(typeof(MyDependency_Implementation))]

namespace App4.Droid
{
    public class MyDependency_Implementation : IMyDependency
    {
        public string GetMessage()
        {
            return "Android Platform";
        }
    }
}