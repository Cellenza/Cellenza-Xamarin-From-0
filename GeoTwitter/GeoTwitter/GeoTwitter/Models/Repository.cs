namespace GeoTwitter.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using GeoTwitter.Tools;

    using Xamarin.Forms;

    public class Repository
    {
        private static readonly List<Tweet> Tweets = new List<Tweet>
                                            {
                                                new Tweet
                                                {
                                                    Date = DateTime.Now.AddDays(-1),
                                                    Text = "le troisième tweet",
                                                    User = "moi",
                                                    TwitterPosition = new TwitterPosition { Latitude=0, Longitude=0},
                                                },
                                                new Tweet
                                                {
                                                    Date = DateTime.Now.AddDays(-1),
                                                    Text = "le deuxieme tweet",
                                                    User = "moi",
                                                    TwitterPosition = new TwitterPosition { Latitude=0, Longitude=0},
                                                },
                                                new Tweet
                                                {
                                                    Date = DateTime.Now.AddDays(-1),
                                                    Text = "le promier tweet",
                                                    User = "moi",
                                                    TwitterPosition = new TwitterPosition { Latitude=0, Longitude=0},
                                                }
                                            };


        public IList<Tweet> GetTweets()
        {
            return Tweets;
        }

        public async void Save(Tweet tweet)
        {
            var positionManager = DependencyService.Get<IPositionManager>();

            var position = await positionManager.GetCurrentPosition();

            if (position != null)
            {
                tweet.TwitterPosition = position;
            }

            Tweets.Add(tweet);
        }
    }
}