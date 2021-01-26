using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartBed
{
    
    public partial class  Motore:Form1
    {
        public static string Motore_move;

        public Motore(string mov)
        {
            if (mov == "up")
            {

                Motore_move = "up";




            }
            else if (mov == "down")
            {
                Motore_move = "down";
                frm1.pictureBox1.Location = new System.Drawing.Point(31, 255);
                frm1.Show();


            }
        }

        public Motore()
        {
        TODO: Complete member initialization
        }

        private void InitializeComponent()
        {
            //((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            //this.SuspendLayout();

            //Motore


            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            //this.ClientSize = new System.Drawing.Size(954, 513);
            //this.Name = "Motore";
            //this.Load += new System.EventHandler(this.Motore_Load);
            //((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            //this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            Motore


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(954, 513);
            this.Name = "Motore";
            this.Load += new System.EventHandler(this.Motore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Motore_Load(object sender, EventArgs e)
        {

        }
    }
    }

