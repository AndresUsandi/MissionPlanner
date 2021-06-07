using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSDroneTracker
{
    public partial class GPSTrackerControl : UserControl
    {
        public GPSTrackerControl()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;

            ComPortList.DataSource = SerialPort.GetPortNames().ToList();
        }
    }
}
