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
	public partial class ImageShow : ContentPage
	{
		public ImageShow (UriImageSource source)
		{
			InitializeComponent ();
            theImage.Source = source;
        }

        void OnTapped(object sender, EventArgs args)
        {
            ((App)Application.Current).pageChange(new BackPage());
        }
	}
}