﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxTrimQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestData testData = new TestData();
            richTextBox1.Rtf = testData.GetDataTest1();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
