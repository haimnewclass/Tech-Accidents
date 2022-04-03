
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.Json;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Item.BL;

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

            int a = 1;
            byte b = 255;

            a = b;
            b = (byte) a;

            accidentsManager = new AccidentsManager();          

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
            //createRandomFiles.Run(iLinesCount,textBox3.Text);
            createRandomFiles.CreateBulkFiles(1000, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadCSVFile readCSVFile = new ReadCSVFile(textBox3.Text);
            readCSVFile.LoadProducts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadCSVFiles readCSVFiles = new ReadCSVFiles();
            readCSVFiles.ScanAndReadAllCSVFiles(textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bank b = new Bank();


        }
    }
}
