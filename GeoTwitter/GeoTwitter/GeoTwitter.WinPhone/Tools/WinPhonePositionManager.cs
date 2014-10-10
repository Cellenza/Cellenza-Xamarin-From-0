using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTwitter.WinPhone.Tools
{
    using Windows.Devices.Geolocation;

    using GeoTwitter.Tools;

    public class WinPhonePositionManager : IPositionManager
    {
        public async Task<TwitterPosition> GetCurrentPosition()
        {
            var geo = new Geolocator();

            var result = await geo.GetGeopositionAsync();

            return new TwitterPosition
            {
                Latitude = result.Coordinate.Latitude,
                Longitude = result.Coordinate.Longitude
            };
        }
    }
}
