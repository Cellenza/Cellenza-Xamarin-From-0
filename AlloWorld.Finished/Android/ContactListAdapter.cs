using AlloWorld.SharedCode;
using Android.App;
using Android.Content;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Android
{
    public class ContactListAdapter : ArrayAdapter<string>
    {
        private DialerModel model;
        private Activity context;
        private int layout;
        private int[] margins;

        public ContactListAdapter(Activity context, int layout, DialerModel model)
            : base(context, layout, model.Contacts.ToArray())
        {

            RandomArray(model.Contacts.Count());

            this.layout = layout;
            this.context = context;
            this.model = model;
        }

        private void RandomArray(int size)
        {
            var random = new Random((int)new DateTime().Ticks);
            var list = new List<int>();
            while (size-- > 0)
            {
                list.Add(random.Next(20,200));
            }
            this.margins = list.ToArray();
        }

        public override Views.View GetView(int position, Views.View convertView, Views.ViewGroup parent)
        {
            if (convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(layout, parent, false);
            }

            InitButton(
                convertView.FindViewById<Button>(Resource.Id.contactbutton),
                position,
                model.Dial);

            return convertView;

        }


        private void InitButton(Button button, int position, Action<string> call)
        {
            var name = GetItem(position);
            button.Text = name;
            button.Click += delegate { call(name); };
            LinearLayout.LayoutParams par = new LinearLayout.LayoutParams(50,50);
            par.SetMargins(margins[position], 0, 0, 0);
            button.LayoutParameters = (par);
        }


    }
}
