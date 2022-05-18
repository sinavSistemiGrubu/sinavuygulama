using System;
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
    public partial class frmsinavsorumlusu : Form
    {
        public frmsinavsorumlusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmsoruekle frm = new frmsoruekle();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmsinavolustur frm = new frmsinavolustur();
            frm.Show();
            this.Hide();
        }
    }
}
