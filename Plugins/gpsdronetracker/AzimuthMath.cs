using System;

namespace Azimuth 
{
    public class AzimuthMath 
    {
        public static double EarthRadiusInMeters(double latitudeRadians)
        {
            // latitudeRadians is geodetic, i.e. that reported by GPS.
            // http://en.wikipedia.org/wiki/Earth_radius
            var a = 6378137.0;  // equatorial radius in meters
            var b = 6356752.3;  // polar radius in meters
            var cos = Math.Cos(latitudeRadians);
            var sin = Math.Sin(latitudeRadians);
            var t1 = a * a * cos;
            var t2 = b * b * sin;
            var t3 = a * cos;
            var t4 = b * sin;
            return Math.Sqrt((t1*t1 + t2*t2) / (t3*t3 + t4*t4));
        }

        
        public static double GeocentricLatitude(double lat)
        {
            // Convert geodetic latitude 'lat' to a geocentric latitude 'clat'.
            // Geodetic latitude is the latitude as given by GPS.
            // Geocentric latitude is the angle measured from center of Earth between a point and the equator.
            // https://en.wikipedia.org/wiki/Latitude#Geocentric_latitude
            var e2 = 0.00669437999014;
            var clat = Math.Atan((1.0 - e2) * Math.Tan(lat));
            return clat;
        }


        public static double Distance (Point ap, Point bp)
        {
            var dx = ap.X - bp.X;
            var dy = ap.Y - bp.Y;
            var dz = ap.Z - bp.Z;
            return Math.Sqrt (dx*dx + dy*dy + dz*dz);
        }

        public static Point RotateGlobe (Location b, Location a, double bradius, double aradius)
        {
            // Get modified coordinates of 'b' by rotating the globe so that 'a' is at lat=0, lon=0.
            Location br = new Location 
            {
                Latitude = b.Latitude, 
                Longitude = (b.Longitude - a.Longitude), 
                Elevation = b.Elevation
            };
            Point brp = br.ToPoint();

            // Rotate brp cartesian coordinates around the z-axis by a.lon degrees,
            // then around the y-axis by a.lat degrees.
            // Though we are decreasing by a.lat degrees, as seen above the y-axis,
            // this is a positive (counterclockwise) rotation (if B's longitude is east of A's).
            // However, from this point of view the x-axis is pointing left.
            // So we will look the other way making the x-axis pointing right, the z-axis
            // pointing up, and the rotation treated as negative.

            var alat = GeocentricLatitude(-a.Latitude * Math.PI / 180.0);
            var acos = Math.Cos(alat);
            var asin = Math.Sin(alat);

            var bx = (brp.X * acos) - (brp.Z * asin);
            var by = brp.Y;
            var bz = (brp.X * asin) + (brp.Z * acos);

            return new Point{ X = bx, Y = by, Z = bz, Radius = bradius};
        }

        
        public static Point NormalizeVectorDiff(Point b, Point a)
        {
            // Calculate norm(b-a), where norm divides a vector by its length to produce a unit vector.
            var dx = b.X - a.X;
            var dy = b.Y - a.Y;
            var dz = b.Z - a.Z;
            var dist2 = dx*dx + dy*dy + dz*dz;
            if (dist2 == 0) {
                return null;
            }
            var dist = Math.Sqrt(dist2);
            return new Point{ X = (dx/dist), Y = (dy/dist), Z = (dz/dist), Radius = 1.0 };
        }
    }
}