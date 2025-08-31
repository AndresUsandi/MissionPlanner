
namespace GPSDroneTracker
{
    partial class GPSTrackerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComPortList = new System.Windows.Forms.ComboBox();
            this.ConnectDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.HomeGroup = new System.Windows.Forms.GroupBox();
            this.HomeHeading = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.HomeAltitude = new System.Windows.Forms.TextBox();
            this.HomeLongitude = new System.Windows.Forms.TextBox();
            this.HomeLatitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Heading = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CurrentAltitude = new System.Windows.Forms.Label();
            this.CurrentLongitude = new System.Windows.Forms.Label();
            this.CurrentLatitude = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Distance = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ElevationValue = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.AzimuthValue = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DiffElevation = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DiffAzimuth = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Elevation = new System.Windows.Forms.Label();
            this.Azimuth = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SetHome = new System.Windows.Forms.Button();
            this.SetTestBedroom = new System.Windows.Forms.Button();
            this.SetTestBackyard = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MinDistanceMeters = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MinChangeDegrees = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.StartStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.HomeGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortList
            // 
            this.ComPortList.FormattingEnabled = true;
            this.ComPortList.Location = new System.Drawing.Point(8, 16);
            this.ComPortList.Margin = new System.Windows.Forms.Padding(2);
            this.ComPortList.Name = "ComPortList";
            this.ComPortList.Size = new System.Drawing.Size(188, 21);
            this.ComPortList.TabIndex = 1;
            // 
            // ConnectDisconnect
            // 
            this.ConnectDisconnect.Location = new System.Drawing.Point(198, 14);
            this.ConnectDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectDisconnect.Name = "ConnectDisconnect";
            this.ConnectDisconnect.Size = new System.Drawing.Size(58, 22);
            this.ConnectDisconnect.TabIndex = 2;
            this.ConnectDisconnect.Text = "Connect";
            this.ConnectDisconnect.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.ComPortList);
            this.groupBox1.Controls.Add(this.ConnectDisconnect);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(325, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tracker Source";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(260, 14);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(58, 22);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // HomeGroup
            // 
            this.HomeGroup.Controls.Add(this.HomeHeading);
            this.HomeGroup.Controls.Add(this.label20);
            this.HomeGroup.Controls.Add(this.HomeAltitude);
            this.HomeGroup.Controls.Add(this.HomeLongitude);
            this.HomeGroup.Controls.Add(this.HomeLatitude);
            this.HomeGroup.Controls.Add(this.label4);
            this.HomeGroup.Controls.Add(this.label5);
            this.HomeGroup.Controls.Add(this.label2);
            this.HomeGroup.Controls.Add(this.Latitude);
            this.HomeGroup.Controls.Add(this.label1);
            this.HomeGroup.Location = new System.Drawing.Point(173, 106);
            this.HomeGroup.Margin = new System.Windows.Forms.Padding(2);
            this.HomeGroup.Name = "HomeGroup";
            this.HomeGroup.Padding = new System.Windows.Forms.Padding(2);
            this.HomeGroup.Size = new System.Drawing.Size(154, 95);
            this.HomeGroup.TabIndex = 4;
            this.HomeGroup.TabStop = false;
            this.HomeGroup.Text = "Home";
            // 
            // HomeHeading
            // 
            this.HomeHeading.Location = new System.Drawing.Point(39, 70);
            this.HomeHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeHeading.Name = "HomeHeading";
            this.HomeHeading.Size = new System.Drawing.Size(91, 20);
            this.HomeHeading.TabIndex = 11;
            this.HomeHeading.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 70);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Head:";
            // 
            // HomeAltitude
            // 
            this.HomeAltitude.Location = new System.Drawing.Point(39, 53);
            this.HomeAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeAltitude.Name = "HomeAltitude";
            this.HomeAltitude.Size = new System.Drawing.Size(91, 20);
            this.HomeAltitude.TabIndex = 7;
            this.HomeAltitude.Text = "0";
            // 
            // HomeLongitude
            // 
            this.HomeLongitude.Location = new System.Drawing.Point(39, 35);
            this.HomeLongitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeLongitude.Name = "HomeLongitude";
            this.HomeLongitude.Size = new System.Drawing.Size(91, 20);
            this.HomeLongitude.TabIndex = 6;
            this.HomeLongitude.Text = "0.0";
            // 
            // HomeLatitude
            // 
            this.HomeLatitude.Location = new System.Drawing.Point(39, 15);
            this.HomeLatitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeLatitude.Name = "HomeLatitude";
            this.HomeLatitude.Size = new System.Drawing.Size(91, 20);
            this.HomeLatitude.TabIndex = 5;
            this.HomeLatitude.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lon:";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(34, 14);
            this.Latitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(0, 13);
            this.Latitude.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lat:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Heading);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.CurrentAltitude);
            this.groupBox2.Controls.Add(this.CurrentLongitude);
            this.groupBox2.Controls.Add(this.CurrentLatitude);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(5, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(164, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Location = new System.Drawing.Point(38, 70);
            this.Heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(13, 13);
            this.Heading.TabIndex = 9;
            this.Heading.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 70);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Head:";
            // 
            // CurrentAltitude
            // 
            this.CurrentAltitude.AutoSize = true;
            this.CurrentAltitude.Location = new System.Drawing.Point(38, 53);
            this.CurrentAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentAltitude.Name = "CurrentAltitude";
            this.CurrentAltitude.Size = new System.Drawing.Size(13, 13);
            this.CurrentAltitude.TabIndex = 7;
            this.CurrentAltitude.Text = "0";
            // 
            // CurrentLongitude
            // 
            this.CurrentLongitude.AutoSize = true;
            this.CurrentLongitude.Location = new System.Drawing.Point(38, 35);
            this.CurrentLongitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentLongitude.Name = "CurrentLongitude";
            this.CurrentLongitude.Size = new System.Drawing.Size(22, 13);
            this.CurrentLongitude.TabIndex = 6;
            this.CurrentLongitude.Text = "0.0";
            // 
            // CurrentLatitude
            // 
            this.CurrentLatitude.AutoSize = true;
            this.CurrentLatitude.Location = new System.Drawing.Point(38, 15);
            this.CurrentLatitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentLatitude.Name = "CurrentLatitude";
            this.CurrentLatitude.Size = new System.Drawing.Size(22, 13);
            this.CurrentLatitude.TabIndex = 5;
            this.CurrentLatitude.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Alt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Lat:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Distance);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.ElevationValue);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.AzimuthValue);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.DiffElevation);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.DiffAzimuth);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Elevation);
            this.groupBox3.Controls.Add(this.Azimuth);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(5, 205);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(322, 96);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculations";
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(81, 53);
            this.Distance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(22, 13);
            this.Distance.TabIndex = 16;
            this.Distance.Text = "0.0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 53);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "Distance:";
            // 
            // ElevationValue
            // 
            this.ElevationValue.AutoSize = true;
            this.ElevationValue.Location = new System.Drawing.Point(204, 73);
            this.ElevationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ElevationValue.Name = "ElevationValue";
            this.ElevationValue.Size = new System.Drawing.Size(22, 13);
            this.ElevationValue.TabIndex = 14;
            this.ElevationValue.Text = "0.0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(130, 73);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Elevation Val:";
            // 
            // AzimuthValue
            // 
            this.AzimuthValue.AutoSize = true;
            this.AzimuthValue.Location = new System.Drawing.Point(81, 73);
            this.AzimuthValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AzimuthValue.Name = "AzimuthValue";
            this.AzimuthValue.Size = new System.Drawing.Size(22, 13);
            this.AzimuthValue.TabIndex = 12;
            this.AzimuthValue.Text = "0.0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 73);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Azimuth Val:";
            // 
            // DiffElevation
            // 
            this.DiffElevation.AutoSize = true;
            this.DiffElevation.Location = new System.Drawing.Point(204, 35);
            this.DiffElevation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiffElevation.Name = "DiffElevation";
            this.DiffElevation.Size = new System.Drawing.Size(22, 13);
            this.DiffElevation.TabIndex = 10;
            this.DiffElevation.Text = "0.0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(130, 35);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Diff Elevation:";
            // 
            // DiffAzimuth
            // 
            this.DiffAzimuth.AutoSize = true;
            this.DiffAzimuth.Location = new System.Drawing.Point(204, 15);
            this.DiffAzimuth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiffAzimuth.Name = "DiffAzimuth";
            this.DiffAzimuth.Size = new System.Drawing.Size(22, 13);
            this.DiffAzimuth.TabIndex = 8;
            this.DiffAzimuth.Text = "0.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Diff Azimuth:";
            // 
            // Elevation
            // 
            this.Elevation.AutoSize = true;
            this.Elevation.Location = new System.Drawing.Point(81, 35);
            this.Elevation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Elevation.Name = "Elevation";
            this.Elevation.Size = new System.Drawing.Size(22, 13);
            this.Elevation.TabIndex = 6;
            this.Elevation.Text = "0.0";
            // 
            // Azimuth
            // 
            this.Azimuth.AutoSize = true;
            this.Azimuth.Location = new System.Drawing.Point(81, 15);
            this.Azimuth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Azimuth.Name = "Azimuth";
            this.Azimuth.Size = new System.Drawing.Size(22, 13);
            this.Azimuth.TabIndex = 5;
            this.Azimuth.Text = "0.0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(134, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 35);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Elevation:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 14);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Azimuth:";
            // 
            // SetHome
            // 
            this.SetHome.AllowDrop = true;
            this.SetHome.Location = new System.Drawing.Point(142, 55);
            this.SetHome.Margin = new System.Windows.Forms.Padding(2);
            this.SetHome.Name = "SetHome";
            this.SetHome.Size = new System.Drawing.Size(77, 22);
            this.SetHome.TabIndex = 12;
            this.SetHome.Text = "Set Drone";
            this.SetHome.UseVisualStyleBackColor = true;
            // 
            // SetTestBedroom
            // 
            this.SetTestBedroom.AllowDrop = true;
            this.SetTestBedroom.Location = new System.Drawing.Point(223, 55);
            this.SetTestBedroom.Margin = new System.Windows.Forms.Padding(2);
            this.SetTestBedroom.Name = "SetTestBedroom";
            this.SetTestBedroom.Size = new System.Drawing.Size(104, 22);
            this.SetTestBedroom.TabIndex = 13;
            this.SetTestBedroom.Text = "Set Bedroom";
            this.SetTestBedroom.UseVisualStyleBackColor = true;
            // 
            // SetTestBackyard
            // 
            this.SetTestBackyard.AllowDrop = true;
            this.SetTestBackyard.Location = new System.Drawing.Point(223, 81);
            this.SetTestBackyard.Margin = new System.Windows.Forms.Padding(2);
            this.SetTestBackyard.Name = "SetTestBackyard";
            this.SetTestBackyard.Size = new System.Drawing.Size(104, 22);
            this.SetTestBackyard.TabIndex = 14;
            this.SetTestBackyard.Text = "Set Backyard";
            this.SetTestBackyard.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.MinDistanceMeters);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.MinChangeDegrees);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Location = new System.Drawing.Point(5, 50);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(126, 52);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minimums";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "m";
            // 
            // MinDistanceMeters
            // 
            this.MinDistanceMeters.Location = new System.Drawing.Point(36, 20);
            this.MinDistanceMeters.Name = "MinDistanceMeters";
            this.MinDistanceMeters.Size = new System.Drawing.Size(19, 20);
            this.MinDistanceMeters.TabIndex = 19;
            this.MinDistanceMeters.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "°";
            // 
            // MinChangeDegrees
            // 
            this.MinChangeDegrees.Location = new System.Drawing.Point(5, 20);
            this.MinChangeDegrees.Name = "MinChangeDegrees";
            this.MinChangeDegrees.Size = new System.Drawing.Size(20, 20);
            this.MinChangeDegrees.TabIndex = 17;
            this.MinChangeDegrees.Text = "10";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(134, 20);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 13);
            this.label29.TabIndex = 4;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(34, 14);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 13);
            this.label32.TabIndex = 1;
            // 
            // StartStop
            // 
            this.StartStop.AllowDrop = true;
            this.StartStop.Location = new System.Drawing.Point(104, 305);
            this.StartStop.Margin = new System.Windows.Forms.Padding(2);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(104, 22);
            this.StartStop.TabIndex = 18;
            this.StartStop.Text = "Start";
            this.StartStop.UseVisualStyleBackColor = true;
            // 
            // GPSTrackerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SetTestBackyard);
            this.Controls.Add(this.SetTestBedroom);
            this.Controls.Add(this.SetHome);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.HomeGroup);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GPSTrackerControl";
            this.Size = new System.Drawing.Size(331, 335);
            this.groupBox1.ResumeLayout(false);
            this.HomeGroup.ResumeLayout(false);
            this.HomeGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button ConnectDisconnect;
        private System.Windows.Forms.GroupBox HomeGroup;
        public System.Windows.Forms.TextBox HomeAltitude;
        public System.Windows.Forms.TextBox HomeLongitude;
        public System.Windows.Forms.TextBox HomeLatitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label CurrentAltitude;
        public System.Windows.Forms.Label CurrentLongitude;
        public System.Windows.Forms.Label CurrentLatitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label Elevation;
        public System.Windows.Forms.Label Azimuth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label DiffElevation;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label DiffAzimuth;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox ComPortList;
        public System.Windows.Forms.Button SetHome;
        public System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox HomeHeading;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label ElevationValue;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label AzimuthValue;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Button SetTestBedroom;
        public System.Windows.Forms.Button SetTestBackyard;
        public System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.Button Reset;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox MinDistanceMeters;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox MinChangeDegrees;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.Button StartStop;
    }
}
