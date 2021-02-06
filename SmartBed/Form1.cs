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
    public partial class Form1 : Form
    {
      
    
        string Bed_State;
        controller mov_bed;
        public Form1()
        {
            InitializeComponent();



           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mov_bed = new controller("down");
            if (Motore.Motore_move == "down")
                this.pictureBox1.Location = new System.Drawing.Point(31, 255);


        }
        //private void button1_Click(object sender, EventArgs e)
        //{


        //  mov_bed = new controller("up");

        //  if (Motore.Motore_move == "up")
        //      this.pictureBox1.Location = new System.Drawing.Point(31, 155)
        //}
        private void button1_Click(object sender, EventArgs e)
        {


            mov_bed = new controller("up");

            if (Motore.Motore_move == "up")
                this.pictureBox1.Location = new System.Drawing.Point(31, 155)
        }
    }
  

    }

