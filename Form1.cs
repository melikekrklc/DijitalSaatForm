﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijitalSaatForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            labelsaniye.Text = saniye.ToString();

            if (saniye==60)
            {
                saniye = 0;
                dakika++;
                labeldk.Text = dakika.ToString();

                if (dakika==60)
                {
                    dakika = 0;
                    saat++;
                    labelsaaat.Text = saat.ToString();

                }
            }

        }
    }
}
