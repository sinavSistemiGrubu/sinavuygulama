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
    public partial class frmsınav : Form
    {
        public frmsınav()
        {
            InitializeComponent();
        }
        public int ogrId;
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmsinavbasla frm = new frmsinavbasla();
            frm.ogrId = ogrId;
            frm.id = Convert.ToInt32(cboxsinavid.Text);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Show();
            
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            


        }
    }
}
