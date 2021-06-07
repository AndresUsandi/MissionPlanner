namespace Azimuth
{
    public class AzimuthResult
    {
        public double Azimuth {get;set;}
        public double Angle {get;set;}
        public double Distance {get;set;}

        public override string ToString()
        {
            return $"Azimuth: {Azimuth:0.0} deg, Altitude: {Angle:0.0} deg, Distance: {Distance:0.00} km";
        }
    }
}