using AlloWorld.SharedCode;
using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP
{
    public class DialService : IDialService
    {
        public void Dial(string name, string number)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = number;
            phoneCallTask.DisplayName = name;

            phoneCallTask.Show();
        }
    }
}
