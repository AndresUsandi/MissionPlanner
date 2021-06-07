
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
            this.StartStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HomeGroup = new System.Windows.Forms.GroupBox();
            this.HomeHeading = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.HomeAltitude = new System.Windows.Forms.Label();
            this.HomeLongitude = new System.Windows.Forms.Label();
            this.HomeLatitude = new System.Windows.Forms.Label();
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
            this.Servo2Value = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Servo1Value = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DiffAngle = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DiffAzimuth = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.Label();
            this.Azimuth = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.MinChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SetHome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.HomeGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortList
            // 
            this.ComPortList.FormattingEnabled = true;
            this.ComPortList.Location = new System.Drawing.Point(16, 31);
            this.ComPortList.Margin = new System.Windows.Forms.Padding(4);
            this.ComPortList.Name = "ComPortList";
            this.ComPortList.Size = new System.Drawing.Size(372, 33);
            this.ComPortList.TabIndex = 1;
            // 
            // StartStop
            // 
            this.StartStop.Location = new System.Drawing.Point(396, 29);
            this.StartStop.Margin = new System.Windows.Forms.Padding(4);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(116, 42);
            this.StartStop.TabIndex = 2;
            this.StartStop.Text = "Start";
            this.StartStop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComPortList);
            this.groupBox1.Controls.Add(this.StartStop);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(514, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tracker Source";
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
            this.HomeGroup.Location = new System.Drawing.Point(276, 146);
            this.HomeGroup.Margin = new System.Windows.Forms.Padding(4);
            this.HomeGroup.Name = "HomeGroup";
            this.HomeGroup.Padding = new System.Windows.Forms.Padding(4);
            this.HomeGroup.Size = new System.Drawing.Size(240, 183);
            this.HomeGroup.TabIndex = 4;
            this.HomeGroup.TabStop = false;
            this.HomeGroup.Text = "Home";
            // 
            // HomeHeading
            // 
            this.HomeHeading.AutoSize = true;
            this.HomeHeading.Location = new System.Drawing.Point(76, 135);
            this.HomeHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeHeading.Name = "HomeHeading";
            this.HomeHeading.Size = new System.Drawing.Size(24, 25);
            this.HomeHeading.TabIndex = 11;
            this.HomeHeading.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 135);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 25);
            this.label20.TabIndex = 10;
            this.label20.Text = "Head:";
            // 
            // HomeAltitude
            // 
            this.HomeAltitude.AutoSize = true;
            this.HomeAltitude.Location = new System.Drawing.Point(76, 101);
            this.HomeAltitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeAltitude.Name = "HomeAltitude";
            this.HomeAltitude.Size = new System.Drawing.Size(24, 25);
            this.HomeAltitude.TabIndex = 7;
            this.HomeAltitude.Text = "0";
            // 
            // HomeLongitude
            // 
            this.HomeLongitude.AutoSize = true;
            this.HomeLongitude.Location = new System.Drawing.Point(76, 67);
            this.HomeLongitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeLongitude.Name = "HomeLongitude";
            this.HomeLongitude.Size = new System.Drawing.Size(42, 25);
            this.HomeLongitude.TabIndex = 6;
            this.HomeLongitude.Text = "0.0";
            // 
            // HomeLatitude
            // 
            this.HomeLatitude.AutoSize = true;
            this.HomeLatitude.Location = new System.Drawing.Point(76, 29);
            this.HomeLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeLatitude.Name = "HomeLatitude";
            this.HomeLatitude.Size = new System.Drawing.Size(42, 25);
            this.HomeLatitude.TabIndex = 5;
            this.HomeLatitude.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lon:";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(68, 27);
            this.Latitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(0, 25);
            this.Latitude.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
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
            this.groupBox2.Location = new System.Drawing.Point(4, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(260, 183);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Location = new System.Drawing.Point(76, 135);
            this.Heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(24, 25);
            this.Heading.TabIndex = 9;
            this.Heading.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 135);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 25);
            this.label18.TabIndex = 8;
            this.label18.Text = "Head:";
            // 
            // CurrentAltitude
            // 
            this.CurrentAltitude.AutoSize = true;
            this.CurrentAltitude.Location = new System.Drawing.Point(76, 101);
            this.CurrentAltitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentAltitude.Name = "CurrentAltitude";
            this.CurrentAltitude.Size = new System.Drawing.Size(24, 25);
            this.CurrentAltitude.TabIndex = 7;
            this.CurrentAltitude.Text = "0";
            // 
            // CurrentLongitude
            // 
            this.CurrentLongitude.AutoSize = true;
            this.CurrentLongitude.Location = new System.Drawing.Point(76, 67);
            this.CurrentLongitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentLongitude.Name = "CurrentLongitude";
            this.CurrentLongitude.Size = new System.Drawing.Size(42, 25);
            this.CurrentLongitude.TabIndex = 6;
            this.CurrentLongitude.Text = "0.0";
            // 
            // CurrentLatitude
            // 
            this.CurrentLatitude.AutoSize = true;
            this.CurrentLatitude.Location = new System.Drawing.Point(76, 29);
            this.CurrentLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentLatitude.Name = "CurrentLatitude";
            this.CurrentLatitude.Size = new System.Drawing.Size(42, 25);
            this.CurrentLatitude.TabIndex = 5;
            this.CurrentLatitude.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Alt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Lat:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Servo2Value);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.Servo1Value);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.DiffAngle);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.DiffAzimuth);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Angle);
            this.groupBox3.Controls.Add(this.Azimuth);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(4, 337);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(508, 162);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculations";
            // 
            // Servo2Value
            // 
            this.Servo2Value.AutoSize = true;
            this.Servo2Value.Location = new System.Drawing.Point(408, 102);
            this.Servo2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Servo2Value.Name = "Servo2Value";
            this.Servo2Value.Size = new System.Drawing.Size(42, 25);
            this.Servo2Value.TabIndex = 14;
            this.Servo2Value.Text = "0.0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(260, 102);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 25);
            this.label22.TabIndex = 13;
            this.label22.Text = "Servo 2:";
            // 
            // Servo1Value
            // 
            this.Servo1Value.AutoSize = true;
            this.Servo1Value.Location = new System.Drawing.Point(116, 102);
            this.Servo1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Servo1Value.Name = "Servo1Value";
            this.Servo1Value.Size = new System.Drawing.Size(42, 25);
            this.Servo1Value.TabIndex = 12;
            this.Servo1Value.Text = "0.0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 102);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 25);
            this.label21.TabIndex = 11;
            this.label21.Text = "Servo 1:";
            // 
            // DiffAngle
            // 
            this.DiffAngle.AutoSize = true;
            this.DiffAngle.Location = new System.Drawing.Point(408, 67);
            this.DiffAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiffAngle.Name = "DiffAngle";
            this.DiffAngle.Size = new System.Drawing.Size(42, 25);
            this.DiffAngle.TabIndex = 10;
            this.DiffAngle.Text = "0.0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 67);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 25);
            this.label19.TabIndex = 9;
            this.label19.Text = "Diff Angle:";
            // 
            // DiffAzimuth
            // 
            this.DiffAzimuth.AutoSize = true;
            this.DiffAzimuth.Location = new System.Drawing.Point(408, 29);
            this.DiffAzimuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiffAzimuth.Name = "DiffAzimuth";
            this.DiffAzimuth.Size = new System.Drawing.Size(42, 25);
            this.DiffAzimuth.TabIndex = 8;
            this.DiffAzimuth.Text = "0.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "Diff Azimuth:";
            // 
            // Angle
            // 
            this.Angle.AutoSize = true;
            this.Angle.Location = new System.Drawing.Point(116, 67);
            this.Angle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(42, 25);
            this.Angle.TabIndex = 6;
            this.Angle.Text = "0.0";
            // 
            // Azimuth
            // 
            this.Azimuth.AutoSize = true;
            this.Azimuth.Location = new System.Drawing.Point(116, 29);
            this.Azimuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Azimuth.Name = "Azimuth";
            this.Azimuth.Size = new System.Drawing.Size(42, 25);
            this.Azimuth.TabIndex = 5;
            this.Azimuth.Text = "0.0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 67);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Angle:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 25);
            this.label16.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 29);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Azimuth:";
            // 
            // MinChange
            // 
            this.MinChange.Location = new System.Drawing.Point(66, 101);
            this.MinChange.Margin = new System.Windows.Forms.Padding(6);
            this.MinChange.Name = "MinChange";
            this.MinChange.Size = new System.Drawing.Size(56, 31);
            this.MinChange.TabIndex = 9;
            this.MinChange.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Degrees";
            // 
            // SetHome
            // 
            this.SetHome.AllowDrop = true;
            this.SetHome.Location = new System.Drawing.Point(281, 95);
            this.SetHome.Margin = new System.Windows.Forms.Padding(4);
            this.SetHome.Name = "SetHome";
            this.SetHome.Size = new System.Drawing.Size(155, 42);
            this.SetHome.TabIndex = 12;
            this.SetHome.Text = "Set Home";
            this.SetHome.UseVisualStyleBackColor = true;
            // 
            // GPSTrackerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SetHome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinChange);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.HomeGroup);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GPSTrackerControl";
            this.Size = new System.Drawing.Size(528, 503);
            this.groupBox1.ResumeLayout(false);
            this.HomeGroup.ResumeLayout(false);
            this.HomeGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.GroupBox HomeGroup;
        public System.Windows.Forms.Label HomeAltitude;
        public System.Windows.Forms.Label HomeLongitude;
        public System.Windows.Forms.Label HomeLatitude;
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
        public System.Windows.Forms.Label Angle;
        public System.Windows.Forms.Label Azimuth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox MinChange;
        public System.Windows.Forms.Label DiffAngle;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label DiffAzimuth;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox ComPortList;
        public System.Windows.Forms.Button SetHome;
        public System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label HomeHeading;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label Servo2Value;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label Servo1Value;
        private System.Windows.Forms.Label label21;
    }
}
