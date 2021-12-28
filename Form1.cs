using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsCounterList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            //Available only txt file
            openFile.Filter = "txt files (*.txt)|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = (openFile.FileName);

                //Read File content 
                txtFilePath.Text = (openFile.FileName);
                string fileContent = File.ReadAllText(openFile.FileName);
                txtFileContent.Text = fileContent; 
                
                //Split content into Dictionary 
                FileContent.addToDictionary(fileContent);

            }

        }
    }
}
