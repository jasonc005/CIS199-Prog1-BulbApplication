//This program switches a bulb on and off when you push the button
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulbApplication
{
    public partial class BulbApp : Form
    {
        public BulbApp()
        {
            InitializeComponent();
        }

        //Makes onBulb visible
        private void onButton_Click(object sender, EventArgs e)
        {
            offBulb.Visible = false;
            onBulb.Visible = true;
        }

        //Makes offBulb visible
        private void offButton_Click(object sender, EventArgs e)
        {
            offBulb.Visible = true;
            onBulb.Visible = false;
        }
    }
}
