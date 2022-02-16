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
using System.Xml;

namespace WordsCounterList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ConcurrentDictionary<string, int> wordsCollection = new ConcurrentDictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
        private List<KeyValuePair<string, int>> frequencyWordList = new List<KeyValuePair<string, int>>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            //Available only txt file
            openFile.Filter = "txt files (*.txt)|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (frequencyWordList.Count > 0 || wordsCollection.Count > 0)
                {
                    frequencyWordList.Clear();
                    wordsCollection.Clear();
                    dataGridView1.Rows.Clear();
                }

                //Read File content 
                txtFilePath.Text = (openFile.FileName);

                LoadingWindow load= new LoadingWindow();
                load.ShowForm(this);

                string fileContent = File.ReadAllText(openFile.FileName);
                txtFileContent.Text = fileContent;

                //Split content into Dictionary 
                frequencyWordList = FileContent.splitIntoWords(wordsCollection, fileContent);


                foreach (var ele in frequencyWordList)
                {
                    dataGridView1.Rows.Add(ele.Key, ele.Value);
                }

                load.Close();
            }

        }
    }
}
