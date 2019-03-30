using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyToManyRelation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ögrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrenci frm = new FormOgrenci();
            frm.Show();
        }

        private void egitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEgitmen frm2 = new FormEgitmen();
            frm2.Show();
        }

        private void ögrenciEgitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIliski frm3 = new FormIliski();
            frm3.Show();
        }
    }
}
