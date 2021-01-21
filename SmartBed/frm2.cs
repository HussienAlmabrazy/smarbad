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
    public partial class frm2 : Form
    {
        public frm2()
        {
           

           
            InitializeComponent();
           
        }
        public  string state( string bedState) 
        {
            Form1 frm1 = new Form1();
            
            if (frm1.pictureBox1.Location.Y != 255)
            {
                bedState = "u";
            }
            else if (frm1.pictureBox1.Location.Y == 255)
                bedState = "d";
             return bedState;
        }
        private void frm2_Load(object sender, EventArgs e)
        {

        }
    }
}
