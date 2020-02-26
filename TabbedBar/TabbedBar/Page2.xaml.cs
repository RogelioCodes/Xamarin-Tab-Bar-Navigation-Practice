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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            picClickFunc();
            picClickFunc2();
            picClickFunc3();
            picClickFunc4();
            picClickFunc5();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://en.wikipedia.org/wiki/HipHop", BrowserLaunchMode.SystemPreferred);
        }

        void picClickFunc() //function that makes image direct to wikipedia page about album
        {

            picClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Midnight_Marauders", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc2() //function that makes image direct to wikipedia page about album
        {

            picClick2.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Atrocity_Exhibition_(album)", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc3() //function that makes image direct to wikipedia page about album
        {

            picClick3.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Exmilitary", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc4() //function that makes image direct to wikipedia page about album
        {

            picClick4.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/The_Massacre", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc5() //function that makes image direct to wikipedia page about album
        {

            picClick5.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/The_Marshall_Mathers_LP", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
    }
}