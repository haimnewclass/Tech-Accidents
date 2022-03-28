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
            long id = long.Parse(textBox1.Text);
            label1.Text =  accidentsManager.Accidents.GetTkinutByAccidentId(id).ToString();

            label2.Text = accidentsManager.Accidents.GetSugDerechByAccidentId(id);

        }
    }
}
