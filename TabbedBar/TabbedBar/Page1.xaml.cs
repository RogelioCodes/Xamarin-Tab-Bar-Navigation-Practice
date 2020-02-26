using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TabbedBar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        int counter = 0;//used to only display alerts once 
        int counter2 = 0;//used to only display alerts once
        public Page1()
        {
            InitializeComponent();
            picClickFunc();
            picClickFunc2();
            picClickFunc3();
            picClickFunc4();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://en.wikipedia.org/wiki/Jazz", BrowserLaunchMode.SystemPreferred);
        }
        protected override void OnAppearing() //displays prompt when page is opened
        {

            if (counter < 1)
            {
                DisplayAlert("Hey!", "This app displays album covers of music artists! You can click on any of the images here to learn more about them.", "OK");
            }
            counter++;
        }
        protected override void OnDisappearing() //displays prompt when page is opened
        {
            if (counter2 < 1)
            {
                DisplayAlert("Hey!", "All of the images in the app are clickable, not just the ones on this page!", "OK");

            }
            counter2++;
        }
        void picClickFunc() //function that makes image direct to wikipedia page about album
        {

            picClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Getz/Gilberto", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc2() //function that makes image direct to wikipedia page about album
        {

            picClick2.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Chet_Baker_Sings", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc3() //function that makes image direct to wikipedia page about album
        {

            picClick3.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Sketches_of_Spain", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc4() //function that makes image direct to wikipedia page about album
        {

            picClick4.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Wizard_of_the_Vibes", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
    }
}