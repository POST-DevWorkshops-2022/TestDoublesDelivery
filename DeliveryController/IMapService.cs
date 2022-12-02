using System;

namespace DeliverySystem
{
    public interface IMapService
    {
        double CalculateETA(Location location1, Location location2);
        void UpdateAverageSpeed(Location location1, Location location2, TimeSpan elapsedTime);
    }
}