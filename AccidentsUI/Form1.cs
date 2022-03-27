using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccidentsUI
{
    public partial class Form1 : Form
    {
        AccidentsManager accidentsManager = new AccidentsManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text =  accidentsManager.Accidents.GetTkinutByAccidentId(long.Parse(textBox1.Text)).ToString();
        }
    }
}
