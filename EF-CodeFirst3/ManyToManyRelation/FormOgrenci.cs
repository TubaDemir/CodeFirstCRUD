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
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }
        DBSingleTon db = new DBSingleTon();

        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            dataGridView1.DataSource = db.Ogrenciler.Select(x => new
            {
                x.OgrenciID,
                x.OgrenciAdi,
                x.OgrenciSoyadi
            }).ToList();
        }

        private void button1_Ekle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.OgrenciAdi = textBox1.Text;
            ogr.OgrenciSoyadi = textBox2.Text;
            db.Ogrenciler.Add(ogr);
            db.SaveChanges();
            Doldur();
        }
    }
}
