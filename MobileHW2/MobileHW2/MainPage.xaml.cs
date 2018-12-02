using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MobileHW2;


namespace MobileHW2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void SignIn_Clicked(object sender, EventArgs e)
        {
            string key = email.Text;
            string pass = password.Text;
            string item = DependencyService.Get<ISherPref>().getData(key);
            bool hasitem = false;
            if (item.Equals(pass)) hasitem = true;
            if (hasitem) MatchFound();
            else DisplayAlert("Login Process", "Username and Password Missmatch", "Cancel");
            
        }

        void OnTap(object sender, EventArgs args)
        {
            Label theLabel = ((Label)sender);
            if (theLabel.Equals(signup))
            {
                string key = email.Text;
                string pass = password.Text;
                DependencyService.Get<ISherPref>().setData(key, pass);
            }
            else if (theLabel.Equals(forgotpass))
            {
                
            }
        }
        async void MatchFound()
        {
            bool answer = await DisplayAlert("Login Process", "Username and Password Match", "Continue", "Cancel");
            if (answer) ((App)Application.Current).pageChange(new BackPage());
        }
    }
}
