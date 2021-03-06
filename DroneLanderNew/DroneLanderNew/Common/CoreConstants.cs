﻿namespace DroneLanderNew.Common
{
    public static class CoreConstants
    {
        public const double Gravity = 3.711;      // Mars gravity (m/s2)
        public const double LanderMass = 17198.0; // Lander mass (kg)
        public const int PollingIncrement = 500;

        public const double StartingAltitude = 5000.0;
        public const double StartingVelocity = 0.0;
        public const double StartingFuel = 1000.0;
        public const double StartingThrust = 0.0;
    }

    public static class MobileCenterConstants
    {
        public const string AndroidAppId = "e6427f43-d67d-4412-ad87-c9c0ab3b18d7";
        public const string iOSAppId = "";
    }

    public static class MobileServiceConstants
    {
        public const string AppUrl = "https://dronelandermobile999.azurewebsites.net";
    }
    public static class TelemetryConstants
    {
        public const string DisplayName = "DOGE";
        public const string Tagline = "such land. much control. amaze.";
    }
}
