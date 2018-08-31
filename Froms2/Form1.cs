﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Froms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(ButtonClick);
            button2.Click += new EventHandler(ButtonClick);
            button3.Click += new EventHandler(ButtonClick);
            button4.Click += new EventHandler(ButtonClick);
            button5.Click += new EventHandler(ButtonClick);
        }

        private void ButtonClick(object sender, EventArgs e)
        {

            Button button = sender as Button;

            MessageBox.Show(button.Text, "Huom");
        }
    }
}
