﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimiProjee
{
    public partial class frmOgrenciPanel : Form
    {
        public frmOgrenciPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmsınav frm=new frmsınav();
            frm.Show();

        }
    }
}
