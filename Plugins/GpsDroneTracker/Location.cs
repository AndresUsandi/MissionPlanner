
using System;
namespace Azimuth
{
    public class Location {
        public double Latitude {get;set;}
        public double Longitude {get;set;}
        public double Elevation {get;set;}

        
        public Point ToPoint()
        {
            // Convert (lat, lon, elv) to (x, y, z).
            var lat = Latitude * Math.PI / 180.0;
            var lon = Longitude * Math.PI / 180.0;
            var radius = AzimuthMath.EarthRadiusInMeters(lat);
            var clat   = AzimuthMath.GeocentricLatitude(lat);

            var cosLon = Math.Cos(lon);
            var sinLon = Math.Sin(lon);
            var cosLat = Math.Cos(clat);
            var sinLat = Math.Sin(clat);
            var x = radius * cosLon * cosLat;
            var y = radius * sinLon * cosLat;
            var z = radius * sinLat;

            // We used geocentric latitude to calculate (x,y,z) on the Earth's ellipsoid.
            // Now we use geodetic latitude to calculate normal vector from the surface, to correct for elevation.
            var cosGlat = Math.Cos(lat);
            var sinGlat = Math.Sin(lat);

            var nx = cosGlat * cosLon;
            var ny = cosGlat * sinLon;
            var nz = sinGlat;

            x += Elevation * nx;
            y += Elevation * ny;
            z += Elevation * nz;

            return new Point {X = x, Y = y, Z = z, Radius = radius, NX = nx, NY = ny, NZ = nz};
        }
    }
}