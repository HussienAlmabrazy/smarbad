using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBed
{
    public partial class Sensor : Form
    {
        static public string x;
        public Sensor()
        {
        
            InitializeComponent();
            if (this.pictureBox1.Location == new System.Drawing.Point(85, 127))
                x = "up";
        }

        private void Sensor_Load(object sender, EventArgs e)
        {

        }
    }
}
