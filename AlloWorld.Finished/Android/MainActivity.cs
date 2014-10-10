using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AlloWorld.SharedCode;
using System.Linq;

namespace Android
{
    [Activity(Label = "Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private DialerModel model;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.AddFlags(WindowManagerFlags.Fullscreen);

            model = new DialerModel(new DialService (this));

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            
            
            // Get our button from the layout resource,
            // and attach an event to it
            ListView list = FindViewById<ListView>(Resource.Id.contactlist);
            list.Adapter = new ContactListAdapter(
                this,
                Resource.Layout.Contact, 
                model);


        }

    }
}

