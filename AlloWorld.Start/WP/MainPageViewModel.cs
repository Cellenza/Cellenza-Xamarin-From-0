using AlloWorld.SharedCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WP
{
    public class Contact {

        public string Name { get; set; }

        public Thickness RandomMargin { get; set; }

        public ICommand DialCommand { get; set; }
    }

    public class MainPageViewModel 
    {
        DialerModel model = new DialerModel();

        public IEnumerable<Contact> Contacts
        {
            get
            {
                var random = new Random((int)new DateTime().Ticks);
                return model.Contacts.Select(c => new Contact
                {
                    Name = c,
                    RandomMargin = new Thickness(random.Next(20, 300), 20, 20, 20),
                    DialCommand = new Command(() => { model.Dial(c); }) 
                });
            }
        }


    }
}                                                                                                                                                                                                                                                                                           