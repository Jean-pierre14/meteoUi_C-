using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metroUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlBttn.Height = button1.Height;
            pnlBttn.Top = button1.Top;
            PannelAcceuil.BringToFront();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pnlBttn.Height = button1.Height;
            pnlBttn.Top = button1.Top;
            PannelAcceuil.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlBttn.Height = button2.Height;
            pnlBttn.Top = button2.Top;
          //  PannelDash.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlBttn.Height = button3.Height;
            pnlBttn.Top = button3.Top;
           // PannelClose.BringToFront();

        }

        private void panelvist_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelacc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
              pnlBttn.Height = button1.Height;
             pnlBttn.Top = button1.Top;
            PannelAcceuil.BringToFront();
            pnlBttn.Hide();
        }
    }
}
