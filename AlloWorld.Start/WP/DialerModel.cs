using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloWorld.SharedCode
{
    public class DialerModel
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>()
        {
            {"Web", "0649836006"},
            {"Alm", "0123456"},
            {"Mobile", "0123456"},
            {"Autres", "07004212"}
        };


        public IEnumerable<string> Contacts
        {
            get
            {
                return contacts.Keys;
            }
        }

        public void Dial(string name)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = contacts[name];
            phoneCallTask.DisplayName = name;

            phoneCallTask.Show();
        }
    }
}
