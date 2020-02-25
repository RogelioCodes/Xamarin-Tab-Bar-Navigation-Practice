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
        
        
        public Page3()
        {
            InitializeComponent();
            
            picClickFunc();
        }
       
        void picClickFunc() //function that makes an image clickable
        {
           
            picClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Browser.OpenAsync("https://en.wikipedia.org/wiki/Independent_music", BrowserLaunchMode.SystemPreferred);
                })
            });
        }
        
        private void Button_Clicked(object sender, EventArgs e) //button that displays wikipedia page about music
        {
            Browser.OpenAsync("https://en.wikipedia.org/wiki/Independent_music", BrowserLaunchMode.SystemPreferred);
        }
        protected override void OnAppearing() //displays prompt when page is opened
        {
            DisplayAlert("Hey!", "This page displays album covers of the indepent music artists!", "OK");

        }
        
    }
}