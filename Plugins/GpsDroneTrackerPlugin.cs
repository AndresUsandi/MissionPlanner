using Azimuth;
using MissionPlanner.GCSViews;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSDroneTracker
{
    public class Plugin : MissionPlanner.Plugin.Plugin
    {
        public override string Name
        {
            get { return "Antenna Tracker through GPS Location"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Andres Usandi"; }
        }

        public override bool Init()
        {
            return true;
        }

        private GPSTrackerControl gpsTracker;
        private double homeLat = double.NaN;
        private double homeLon = double.NaN;
        private double homeAlt = double.NaN;
        private double homeHeading = double.NaN;
        private double currentLat = double.NaN;
        private double currentLon = double.NaN;
        private double currentAlt = double.NaN;
        private double currentHeading = double.NaN;
        private bool isRunning = false;
        private double minChangeAngle = double.NaN;
        private double lastAzimuth = double.NaN;
        private double lastAngle = double.NaN;
        private double servo1Value = double.NaN;
        private double servo2Value = double.NaN;
        private SerialPort serialPort;

        public override bool Loaded()
        {
            gpsTracker = new GPSTrackerControl();
            gpsTracker.StartStop.Click += StartStop_Click;
            gpsTracker.SetHome.Click += SetHome_Click;
            ThemeManager.ApplyThemeTo(gpsTracker);

            TabPage controlTabPage = new TabPage("GPS Drone Tracker");
            controlTabPage.Controls.Add(gpsTracker);
            Host.MainForm.FlightData.tabControlactions.TabPages.Add(controlTabPage);
            Host.MainForm.FlightData.tabControlactions.Multiline = true;

            Host.comPort.SubscribeToPacketType(MAVLink.MAVLINK_MSG_ID.VFR_HUD, VFR_HUD_Handler);
            Host.comPort.SubscribeToPacketType(MAVLink.MAVLINK_MSG_ID.GLOBAL_POSITION_INT, GLOBAL_POSITION_INT_Handler);

            return true;
        }

        private void SetHome_Click(object sender, EventArgs e)
        {
            homeLat = currentLat;
            homeLon = currentLon;
            homeAlt = currentAlt;
            homeHeading = currentHeading;
            gpsTracker.BeginInvoke(new Action(() =>
            {
                gpsTracker.HomeLatitude.Text = $"{homeLat:0.000000}";
                gpsTracker.HomeLongitude.Text = $"{homeLon:0.000000}";
                gpsTracker.HomeAltitude.Text = $"{homeAlt:0.00}";
                gpsTracker.HomeHeading.Text = $"{(short)homeHeading:0}";
            }));
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                gpsTracker.StartStop.Text = "Stop";
                isRunning = true;
                minChangeAngle = double.Parse(gpsTracker.MinChange.Text);
                serialPort = new SerialPort(gpsTracker.ComPortList.Text, 115000);
                serialPort.Open();
            }
            else
            {
                gpsTracker.StartStop.Text = "Start";
                isRunning = false;
            }
        }

        public override bool Loop()
        {
            return true;
        }

        public override bool Exit()
        {
            return true;
        }

        private bool VFR_HUD_Handler(MAVLink.MAVLinkMessage message)
        {
            MAVLink.mavlink_vfr_hud_t data = (MAVLink.mavlink_vfr_hud_t)message.data;
            currentHeading = (double)data.heading;
            gpsTracker.BeginInvoke(new Action(() =>
            {
                gpsTracker.Heading.Text = $"{(short)currentHeading:0}";
            }));
            return true;
        }

        private bool GLOBAL_POSITION_INT_Handler(MAVLink.MAVLinkMessage message)
        {
            MAVLink.mavlink_global_position_int_t data = (MAVLink.mavlink_global_position_int_t)message.data;
            currentLat = data.lat / 10000000.0d;
            currentLon = data.lon / 10000000.0d;
            currentAlt = data.alt / 1000.0d;
            AzimuthResult result = null;
            if (!double.IsNaN(homeLat) && !double.IsNaN(homeLon) && !double.IsNaN(homeAlt))
            {
                result = Azimuth.Azimuth.Calculate(new AzimuthInput
                {
                    A_Latitude = homeLat,
                    A_Longitude = homeLon,
                    A_Elevation = homeAlt,
                    B_Latitude = currentLat,
                    B_Longitude = currentLon,
                    B_Elevation = currentAlt
                });
            }

            double diffAzimuth = result == null ? double.NaN : result.Azimuth - lastAzimuth;
            double diffAngle = result == null ? double.NaN : result.Angle - lastAngle;
            if ((double.IsNaN(lastAzimuth) && result != null) || (diffAzimuth > minChangeAngle || diffAzimuth < -minChangeAngle))
            {
                lastAzimuth = result.Azimuth;
                if (isRunning)
                {
                    double correctedAzimuth = lastAzimuth - homeHeading;
                    servo1Value = (int)correctedAzimuth > 180 ? 360 - (int)correctedAzimuth : (int)correctedAzimuth;
                    serialPort.WriteLine($"1{servo1Value}");
                    serialPort.ReadLine();
                }

            }
            if ((double.IsNaN(lastAngle) && result != null) || (diffAngle > minChangeAngle || diffAngle < -minChangeAngle))
            {
                lastAngle = result.Angle;
                if (isRunning)
                {
                    servo2Value = lastAngle;
                    serialPort.WriteLine($"2{(int)servo2Value}");
                    serialPort.ReadLine();
                }
            }


            gpsTracker.BeginInvoke(new Action(() =>
            {
                gpsTracker.CurrentLatitude.Text = $"{currentLat:0.000000}";
                gpsTracker.CurrentLongitude.Text = $"{currentLon:0.000000}";
                gpsTracker.CurrentAltitude.Text = $"{currentAlt:0.00}";
                gpsTracker.Azimuth.Text = $"{(result == null ? 0 : result.Azimuth):0.0}";
                gpsTracker.Angle.Text = $"{(result == null ? 0 : result.Angle):0.0}";
                gpsTracker.DiffAzimuth.Text = $"{diffAzimuth:0.0}";
                gpsTracker.DiffAngle.Text = $"{diffAngle:0.0}";
                gpsTracker.Servo1Value.Text = $"{servo1Value:0}";
                gpsTracker.Servo2Value.Text = $"{servo2Value:0}";
            }));

            return true;
        }
    }
}
