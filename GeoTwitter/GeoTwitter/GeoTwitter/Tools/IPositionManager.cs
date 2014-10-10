namespace GeoTwitter.Tools
{
    using System.Threading.Tasks;

    public interface IPositionManager
    {
        Task<TwitterPosition> GetCurrentPosition();
    }
}