using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoTwitter.Droid.Tools
{
    using System.Threading.Tasks;

    using GeoTwitter.Tools;

    using Xamarin.Geolocation;

    public class AndroidPositionManager : IPositionManager
    {
        public System.Threading.Tasks.Task<GeoTwitter.Tools.TwitterPosition> GetCurrentPosition()
        {
            return Task.Run(
                        async () =>
                            {
                                var geo = new Geolocator(Android.App.Application.Context);

                                var result = await geo.GetPositionAsync(1000);

                                return new TwitterPosition { Latitude = result.Latitude, Longitude = result.Longitude };
                            });
        }
    }
}
