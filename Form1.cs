using System;
using System.Collections.Concurrent;
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

        public ConcurrentDictionary<string, int> wordsCollection = new ConcurrentDictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            OpenFileDialog openFile = new OpenFileDialog();

            //Available only txt file
            openFile.Filter = "txt files (*.txt)|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Console.WriteLine(wordsCollection.Keys.Count);
                txtFilePath.Text = (openFile.FileName);

                //Read File content 
                txtFilePath.Text = (openFile.FileName);
                string fileContent = File.ReadAllText(openFile.FileName);
                txtFileContent.Text = fileContent; 
                
                //Split content into Dictionary 
                IOrderedEnumerable<KeyValuePair<string, int>> frequencyWordList = FileContent.splitIntoWords(wordsCollection, fileContent);
                foreach (var ele in frequencyWordList)
                {
                    dataGridView1.Rows.Add(ele.Key, ele.Value);
                }
            }

        }
    }
}
