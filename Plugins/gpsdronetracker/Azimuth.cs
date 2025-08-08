using System;

namespace Azimuth
{
    public class Azimuth
    {
        public static AzimuthResult Calculate(AzimuthInput args)
        {
            if (args.Origin_Latitude > 90 || args.Origin_Latitude < -90)
                throw new ArgumentException("Latitude must be between -90 and 90", "A_Latitude");
            if (args.Target_Latitude > 90 || args.Target_Latitude < -90)
                throw new ArgumentException("Latitude must be between -90 and 90", "B_Latitude");

            if (args.Origin_Longitude > 180 || args.Origin_Longitude < -180)
                throw new ArgumentException("Longitude must be between -180 and 190", "A_Longitude");
            if (args.Target_Longitude > 180 || args.Target_Longitude < -180)
                throw new ArgumentException("Longitude must be between -180 and 190", "B_Longitude");

            if (args.Origin_Elevation < 0)
                throw new ArgumentException("Altitude must be more than 0", "A_Elevation");
            if (args.Target_Elevation < 0)
                throw new ArgumentException("Altitude must be more than 0", "B_Elevation");

            double result_distance = 0;
            double result_azimuth = 0;
            double result_elevation = 0;

            Location a = new Location() { Latitude = args.Origin_Latitude, Longitude = args.Origin_Longitude, Elevation = args.Origin_Elevation };
            Location b = new Location() { Latitude = args.Target_Latitude, Longitude = args.Target_Longitude, Elevation = args.Target_Elevation };
            var ap = a.ToPoint();
            var bp = b.ToPoint();
            result_distance = 0.001 * AzimuthMath.Distance(ap, bp);

            // Let's use a trick to calculate azimuth:
            // Rotate the globe so that point A looks like latitude 0, longitude 0.
            // We keep the actual radii calculated based on the oblate geoid,
            // but use angles based on subtraction.
            // Point A will be at x=radius, y=0, z=0.
            // Vector difference B-A will have dz = N/S component, dy = E/W component.
            var br = AzimuthMath.RotateGlobe(b, a, bp.Radius, ap.Radius);
            if (br.Z * br.Z + br.Y * br.Y > 1.0e-6)
            {
                var theta = Math.Atan2(br.Z, br.Y) * 180.0 / Math.PI;
                var azimuth = 90.0 - theta;
                if (azimuth < 0.0)
                {
                    azimuth += 360.0;
                }
                if (azimuth > 360.0)
                {
                    azimuth -= 360.0;
                }
                result_azimuth = azimuth;
            }

            var bma = AzimuthMath.NormalizeVectorDiff(bp, ap);
            if (bma != null)
            {
                // Calculate altitude, which is the angle above the horizon of B as seen from A.
                // Almost always, B will actually be below the horizon, so the altitude will be negative.
                // The dot product of bma and norm = cos(zenith_angle), and zenith_angle = (90 deg) - altitude.
                // So altitude = 90 - acos(dotprod).
                var elevation = 90.0 - (180.0 / Math.PI) * Math.Acos(bma.X * ap.NX + bma.Y * ap.NY + bma.Z * ap.NZ);
                result_elevation = elevation;
            }

            return new AzimuthResult
            {
                Azimuth = result_azimuth,
                Elevation = result_elevation,
                Distance = result_distance * 1000 // Convert to meters
            };
        }
    }
}