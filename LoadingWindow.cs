﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsCounterList
{
    public partial class LoadingWindow : Form
    {
        public LoadingWindow()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        public void ShowForm(Form f)
        {
            //this.CenterToParent();
            this.Show(f);
            this.Refresh();
        }

    }
}
