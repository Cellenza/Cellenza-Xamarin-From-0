using GeoTwitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTwitter.VM
{
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class CreateTweetViewModel : INotifyPropertyChanged
    {
        private Repository repository;

        public CreateTweetViewModel()
        {
            this.repository = new Repository();
        }

        private string message;

        public string Message
        {
            get { return this.message; }
            set
            {
                this.message = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Message"));
            }
        }

        public ICommand SendCommand {
            get
            {
                return  new Command(
                    () =>
                        {
                            this.repository.Save(new Tweet() { Date = DateTime.Now, Text = this.Message, User = "Moi", });

                            this.Message = string.Empty;
                        });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
