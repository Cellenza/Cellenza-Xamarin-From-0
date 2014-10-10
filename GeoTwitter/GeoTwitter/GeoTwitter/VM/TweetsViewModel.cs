using GeoTwitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTwitter.VM
{
    public class TweetsViewModel
    {
        private Repository repository;

        public TweetsViewModel()
        {
            this.repository = new Repository();
        }

        public IEnumerable<Tweet> Tweets
        {
            get
            {
                return this.repository.GetTweets();
            }
        }
    }
}
