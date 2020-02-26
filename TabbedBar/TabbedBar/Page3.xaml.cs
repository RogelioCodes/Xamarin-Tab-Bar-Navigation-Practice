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
    public partial class Page3 : ContentPage
    {
        
        int counter = 0;
        int counter2 = 0;
        public Page3()
        {
            InitializeComponent();
            picClickFunc();
            picClickFunc2();
            picClickFunc3();
            picClickFunc4();
        }
        protected override void OnAppearing()
        {
            ContentPage content = page3;
            if(counter == 0) //color is cycled between a few variations.
            {
                page3.BackgroundColor = Color.Orange;
                counter++;
            }
            else if(counter ==1)
            {
                page3.BackgroundColor = Color.Pink;
                counter++;
            }
            else if(counter == 2)
            {
                page3.BackgroundColor = Color.Pink;
                counter++;
            }
            else if (counter == 3)
            {
                page3.BackgroundColor = Color.Bisque;
                counter++;
            }
            else if (counter == 4)
            {
                page3.BackgroundColor = Color.SeaShell;
                counter++;
            }
            else if (counter > 4)
            {
                counter = 0;
            }


        }
        protected override void OnDisappearing() //displays prompt when page is opened
        {
            if (counter2 < 1)
            {
                DisplayAlert("Hey!", "The background color will change every time you leave this page!", "OK");

            }
            counter2++;
        }

        void picClickFunc() //function that makes image direct to wikipedia page about album
        {

            picClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/LP1_(FKA_Twigs_album)", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc2() //function that makes image direct to wikipedia page about album
        {

            picClick2.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Time_%27n%27_Place", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc3() //function that makes image direct to wikipedia page about album
        {

            picClick3.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Rina_Sawayama", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        void picClickFunc4() //function that makes image direct to wikipedia page about album
        {

            picClick4.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/%22Heroes%22_(David_Bowie_album)", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
       

        private void Button_Clicked(object sender, EventArgs e) //button that displays wikipedia page about music
        {
            Browser.OpenAsync("https://en.wikipedia.org/wiki/Independent_music", BrowserLaunchMode.SystemPreferred);
        }
        
        
    }
}