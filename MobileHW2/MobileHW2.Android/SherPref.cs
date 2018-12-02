using System.Net;
using Xamarin.Forms;
using Android.Webkit;
using System;
using Android.Content;
using Android.Preferences;

[assembly: Dependency(typeof(MobileHW2.Droid.SherPref))]
namespace MobileHW2.Droid
{
    public class SherPref : ISherPref
    {
        public void setData(string key, string pass)
        {
            Context mContext = Android.App.Application.Context;
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(mContext);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, pass);
            editor.Apply();
        }

        public string getData(string key)
        {
            Context mContext = Android.App.Application.Context;
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(mContext);
            String item = prefs.GetString(key, "N0_1t3m");
            return item;
        }
    }
}