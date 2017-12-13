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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void OnBackButton(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnNextButton(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        async void OnButton(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScrollView1());
        }

        async void OnCalculator(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calculator());
        }

        async void OnLogin(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout2());
        }

        async void OnAbsolute(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayout1());
        }

        async void OnTabbedPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }

        async void OnListButton(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListView1());
        }

        async void OnBindingButton(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Binding1());
        }

        async void OnImageButton(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Binding2());
        }

        async void OnBindButton(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Binding3());
        }

        async void OnCollectionButton(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Binding4());
        }

        async void OnImage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image1());
        }

        async void OnAssign(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assignment());
        }

        async void OnContxt(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContextAction());
        }

        async void OnCarousel(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carousel());
        }

        async void OnEntry(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry1());
        }

        void OnDependency(Object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak("Teligenz Tech Solutions pvt ltd");
        }

        async void OnMyDependency(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyDependencyPage());
        }

        async void OnStyle(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Style1());
        }

        async void OnImplicitStyle(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitStyle());
        }

        async void OnGlobalStyle(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalStyle());
        }

        async void OnStyleInheritance(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StyleInheritance());
        }

        async void OnDynamicStyle(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicStyle());
        }
    }
}