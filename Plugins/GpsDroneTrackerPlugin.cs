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
        private double minDistance = double.NaN;
        private double lastAzimuth = double.NaN;
        private double lastElevation = double.NaN;
        private double azimuthValue = double.NaN;
        private double elevationValue = double.NaN;
        private SerialPort serialPort;
        private System.Threading.Timer timer;

        public override bool Loaded()
        {
            try
            {
                gpsTracker = new GPSTrackerControl();
                gpsTracker.ConnectDisconnect.Click += ConnectDisconnect_Click;
                gpsTracker.StartStop.Click += StartStop_Click;
                gpsTracker.SetHome.Click += SetDrone_Click;
                gpsTracker.SetTestBedroom.Click += SetTestBedroom_Click;
                gpsTracker.SetTestBackyard.Click += SetTestBackyard_Click;
                gpsTracker.Reset.Click += Reset_Click;
                gpsTracker.HomeLatitude.TextChanged += (s, e) =>
                {
                    if (double.TryParse(gpsTracker.HomeLatitude.Text, out double val))
                        homeLat = val;
                };
                gpsTracker.HomeLongitude.TextChanged += (s, e) =>
                {
                    if (double.TryParse(gpsTracker.HomeLongitude.Text, out double val))
                        homeLon = val;
                };
                gpsTracker.HomeAltitude.TextChanged += (s, e) =>
                {
                    if (double.TryParse(gpsTracker.HomeAltitude.Text, out double val))
                        homeAlt = val;
                };
                gpsTracker.HomeHeading.TextChanged += (s, e) =>
                {
                    if (double.TryParse(gpsTracker.HomeHeading.Text, out double val))
                        homeHeading = val;
                };
                ThemeManager.ApplyThemeTo(gpsTracker);

                TabPage controlTabPage = new TabPage("GPS Drone Tracker");
                controlTabPage.Controls.Add(gpsTracker);

                Host.MainForm.Invoke(new Action(() =>
                {
                    timer = new System.Threading.Timer((state) =>
                    {
                        Host.MainForm.Invoke(new Action(() =>
                        {
                            if (!Host.MainForm.FlightData.tabControlactions.TabPages.Contains(controlTabPage))
                                Host.MainForm.FlightData.tabControlactions.TabPages.Insert(0, controlTabPage);
                        }));
                    }, null, 1000, 1000);
                }));

                Host.comPort.SubscribeToPacketType(MAVLink.MAVLINK_MSG_ID.VFR_HUD, VFR_HUD_Handler, 0, 0, false);
                Host.comPort.SubscribeToPacketType(MAVLink.MAVLINK_MSG_ID.GLOBAL_POSITION_INT, GLOBAL_POSITION_INT_Handler, 0, 0, false);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading GPS Drone Tracker plugin: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void SetTestBedroom_Click(object sender, EventArgs e)
        {
            lastAzimuth = double.NaN;
            lastElevation = double.NaN;
            minChangeAngle = double.Parse(gpsTracker.MinChangeDegrees.Text);
            minDistance = double.Parse(gpsTracker.MinDistanceMeters.Text);
            homeLat = 47.713972;
            homeLon = -122.223321;
            homeAlt = 130;
            homeHeading = 71;
            gpsTracker.BeginInvoke(new Action(() =>
            {
                gpsTracker.HomeLatitude.Text = $"{homeLat:0.000000}";
                gpsTracker.HomeLongitude.Text = $"{homeLon:0.000000}";
                gpsTracker.HomeAltitude.Text = $"{homeAlt:0.00}";
                gpsTracker.HomeHeading.Text = $"{(short)homeHeading:0}";
            }));
        }

        private void SetTestBackyard_Click(object sender, EventArgs e)
        {
            lastAzimuth = double.NaN;
            lastElevation = double.NaN;
            minChangeAngle = double.Parse(gpsTracker.MinChangeDegrees.Text);
            minDistance = double.Parse(gpsTracker.MinDistanceMeters.Text);
            homeLat = 47.7138736678448;
            homeLon = -122.223428785801;
            homeAlt = 120;
            homeHeading = 90;
            gpsTracker.BeginInvoke(new Action(() =>
            {
                gpsTracker.HomeLatitude.Text = $"{homeLat:0.000000}";
                gpsTracker.HomeLongitude.Text = $"{homeLon:0.000000}";
                gpsTracker.HomeAltitude.Text = $"{homeAlt:0.00}";
                gpsTracker.HomeHeading.Text = $"{(short)homeHeading:0}";
            }));
        }

        private void SetDrone_Click(object sender, EventArgs e)
        {
            lastAzimuth = double.NaN;
            lastElevation = double.NaN;
            minChangeAngle = double.Parse(gpsTracker.MinChangeDegrees.Text);
            minDistance = double.Parse(gpsTracker.MinDistanceMeters.Text);
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

        private void ConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                gpsTracker.ConnectDisconnect.Text = "Disconnect";
                serialPort = new SerialPort(gpsTracker.ComPortList.Text, 115000);
                serialPort.Open();
            }
            else
            {
                gpsTracker.ConnectDisconnect.Text = "Connect";
                serialPort.Close();
                serialPort.Dispose();
            }
        }
        private void StartStop_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                if (!isRunning)
                {
                    lastAzimuth = double.NaN;
                    lastElevation = double.NaN;
                    minChangeAngle = double.Parse(gpsTracker.MinChangeDegrees.Text);
                    minDistance = double.Parse(gpsTracker.MinDistanceMeters.Text);
                    gpsTracker.StartStop.Text = "Stop";
                    isRunning = true;
                }
                else
                {
                    gpsTracker.StartStop.Text = "Start";
                    isRunning = false;
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine("0 0");
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
                    Origin_Latitude = homeLat,
                    Origin_Longitude = homeLon,
                    Origin_Elevation = homeAlt,
                    Target_Latitude = currentLat,
                    Target_Longitude = currentLon,
                    Target_Elevation = currentAlt
                });
            }

            bool shouldMove = false;
            double diffAzimuth = result == null ? double.NaN : result.Azimuth - lastAzimuth;
            double diffElevation = result == null ? double.NaN : result.Elevation - lastElevation;
            if (
                (double.IsNaN(lastAzimuth) && result != null) || // if its the first time we need to set a value for the azimuth
                ((diffAzimuth > minChangeAngle || diffAzimuth < -minChangeAngle) && (result.Distance > minDistance)) // or if the azimuth and distance have changed more than the minimums
                )
            {
                lastAzimuth = result.Azimuth;
                double correctedAzimuth = result.Azimuth;
                correctedAzimuth = correctedAzimuth - homeHeading;
                correctedAzimuth = correctedAzimuth > 180 ? (360 - correctedAzimuth) * -1 : correctedAzimuth;
                correctedAzimuth = correctedAzimuth < -180 ? 360 + correctedAzimuth : correctedAzimuth;
                azimuthValue = correctedAzimuth;
                shouldMove = true;
            }
            if (
                (double.IsNaN(lastElevation) && result != null) || // if its the first time we need to set a value for the elevation
                ((diffElevation > minChangeAngle || diffElevation < -minChangeAngle) && (result.Distance > minDistance)) // or if the elevation and distance have changed more than the minimums
                )
            {
                lastElevation = result.Elevation;
                elevationValue = lastElevation;
                shouldMove = true;
            }

            if(isRunning && shouldMove)
                serialPort.WriteLine($"{azimuthValue} {elevationValue}");

            gpsTracker.BeginInvoke(new Action(() =>
            {
                gpsTracker.CurrentLatitude.Text = $"{currentLat:0.000000}";
                gpsTracker.CurrentLongitude.Text = $"{currentLon:0.000000}";
                gpsTracker.CurrentAltitude.Text = $"{currentAlt:0.00}";
                gpsTracker.Azimuth.Text = $"{(result == null ? 0 : result.Azimuth):0.0}";
                gpsTracker.Elevation.Text = $"{(result == null ? 0 : result.Elevation):0.0}";
                gpsTracker.Distance.Text = $"{(result == null ? 0 : result.Distance):0.0}";
                gpsTracker.DiffAzimuth.Text = $"{diffAzimuth:0.0}";
                gpsTracker.DiffElevation.Text = $"{diffElevation:0.0}";
                gpsTracker.AzimuthValue.Text = $"{azimuthValue:0}";
                gpsTracker.ElevationValue.Text = $"{elevationValue:0}";
            }));

            return true;
        }
    }
}
