using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileHW2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BackPage : TabbedPage
    {
        public BackPage ()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            string callNum = "";
            string Pname = "";
            Button theButton = ((Button)sender);
            if (theButton.Equals(ahmet))
            {
                Pname = "ahmet Arslan";
                callNum = "555-555-5555";
            }
            else if (theButton.Equals(yasar))
            {
                Pname = "Yaşar Hoşcan";
                callNum = "555-444-4444";
            }
            else if (theButton.Equals(serkan))
            {
                Pname = "Serkan Günal";
                callNum = "555-333-3333";
            }
            else if (theButton.Equals(cihan)) {
                Pname = "Cihan Kaleli";
                callNum = "555-222-2222";
            }
            else if (theButton.Equals(alperU))
            {
                Pname = "Alper Uysal";
                callNum = "555-111-1111";
            }
            else if (theButton.Equals(alperB))
            {
                Pname = "Alper Bilge";
                callNum = "555-444-3333";
            }
            else if (theButton.Equals(sevcan))
            {
                Pname = "Sevcan Yılmaz";
                callNum = "555-444-2222";
            }
            else if (theButton.Equals(burcu))
            {
                Pname = "Burcu Yılmazer";
                callNum = "555-444-1111";
            }
            CallArranger(Pname, callNum);
        }

        void OnTapped(object sender, EventArgs args)
        {
            Image theImage = ((Image)sender);
            Xamarin.Forms.UriImageSource source = ((Xamarin.Forms.UriImageSource)theImage.Source);
            
            ((App)Application.Current).pageChange2(new ImageShow(source));
        }
        


        async void CallArranger(string Pname, string callNum)
        {
            bool answer = await DisplayAlert("Dial a Number", "Would you like to call " + Pname + "\nGSM:" + callNum, "Yes", "No");
            if (answer) Device.OpenUri(new Uri("tel:" + callNum + ""));
        }
    }
}