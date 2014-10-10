using AlloWorld.SharedCode;
using Android.App;
using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Android
{
    public class DialService : IDialService
    {
        private Activity mainActivity;

        public DialService(Activity mainActivity)
        {
            this.mainActivity = mainActivity;
        }
        public void Dial(string name, string number)
        {
            Intent callIntent = new Intent(Intent.ActionCall);
            callIntent.SetData(Net.Uri.Parse("tel:" + number));
            mainActivity.StartActivity(callIntent);
        }
    }
}
