using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloWorld.SharedCode
{
    public class DialerModel
    {
        IDialService service;
        Dictionary<string, string> contacts = new Dictionary<string, string>()
        {
            {"Web", "0123456"},
            {"Alm", "0123456"},
            {"Mobile", "0123456"},
            {"Autres", "0762004212"}
        };

        public DialerModel(IDialService dialService)
        {
            this.service = dialService;
        }

        public IEnumerable<string> Contacts
        {
            get
            {
                return contacts.Keys;
            }
        }

        public void Dial(string name)
        {
            service.Dial(name, contacts[name]);
        }
    }
}
