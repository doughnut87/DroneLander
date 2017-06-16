using DroneLanderNew.Common;

namespace DroneLanderNew.Models
{
    public enum LandingResultType { Landed, Kaboom, }
    public class LandingParameters
    {
        public LandingParameters()
        {
            this.Altitude = CoreConstants.StartingAltitude;
            this.Velocity = CoreConstants.StartingVelocity;
            this.Fuel = CoreConstants.StartingFuel;
            this.Thrust = CoreConstants.StartingThrust;
        }

        public double Altitude;
        public double Velocity;
        public double Fuel;
        public double Thrust;
    }
}