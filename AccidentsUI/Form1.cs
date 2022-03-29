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
        AccidentsManager accidentsManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accidentsManager = new AccidentsManager();
            long id = long.Parse(textBox1.Text);
            label1.Text =  accidentsManager.Accidents.GetTkinutByAccidentId(id).ToString();

            label2.Text = accidentsManager.Accidents.GetSugDerechByAccidentId(id);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string linesCount = textBox2.Text;
            int iLinesCount = int.Parse(linesCount);
            CreateRandomFiles createRandomFiles = new CreateRandomFiles();
            createRandomFiles.Run(iLinesCount,textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadCSVFile readCSVFile = new ReadCSVFile(textBox3.Text);
            string[] lines = readCSVFile.Read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadCSVFiles readCSVFiles = new ReadCSVFiles();
            readCSVFiles.ScanAndReadAllCSVFiles(textBox4.Text);
        }
    }
}
