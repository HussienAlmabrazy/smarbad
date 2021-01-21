using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartBed
{
    public partial class controller : Form
    {
        Form1 f = new Form1();
        
        string State_bed;
        Motore m;
        public controller(string bed_mov)
        {
            sensor sensor = new sensor();
            InitializeComponent();
           
            sensor.state(State_bed);
            if (State_bed != "u" )
            {
                m = new Motore(bed_mov);
            }
            else if (State_bed !="d")
            {
                m = new Motore(bed_mov);
            }
            else
                MessageBox.Show("the bed in the pleace you want");
            
        }

        private void controller_Load(object sender, EventArgs e)
        {

        }
    }
}
