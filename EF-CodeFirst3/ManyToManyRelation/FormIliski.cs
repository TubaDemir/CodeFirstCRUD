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
    public partial class FormIliski : Form
    {
        public FormIliski()
        {
            InitializeComponent();
        }
        DBSingleTon db = new DBSingleTon();
        private void FormIliski_Load(object sender, EventArgs e)
        {
            //var combo = db.Egitmenler.Select(x => new
            //{
            //    x.EgitmenID,
            //    isim = x.EgitmenAdi + " " + x.EgitmenSoyadi

            //}).ToList();
            //comboBox1.DisplayMember = "isim";
            //comboBox1.ValueMember = "EgitmenID";

            //comboBox1.DataSource = combo;

            //var listbox = db.Ogrenciler.Select(x => new
            //{
            //    x.OgrenciID,
            //    isim = x.OgrenciAdi + " " + x.OgrenciSoyadi

            //}).ToList();
            //listBox1.DisplayMember = "isim";
            //listBox1.ValueMember = "OgrenciID";

            //listBox1.DataSource = listbox;

            ////2.Yol
            listBox1.DisplayMember = "OgrenciAdi";
            listBox1.DataSource = db.Ogrenciler.ToList();
            comboBox1.DisplayMember = "EgitmenAdi";
            comboBox1.DataSource = db.Egitmenler.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Egitmen seciliEgitmen = comboBox1.SelectedItem as Egitmen;
            var egitmen = db.Egitmenler.Find(seciliEgitmen.EgitmenID);
            foreach (Ogrenci item in listBox1.SelectedItems)
            {
                egitmen.Ogrenci.Add(item);
            }
            db.SaveChanges();
            listBox1.SelectedItems.Clear();
            dataGridView1.DataSource = egitmen.Ogrenci.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = 6;
            Egitmen seciliEgitmen = comboBox1.SelectedItem as Egitmen;
            var egitmeninOgrencileri = db.Egitmenler.Find(seciliEgitmen.EgitmenID).Ogrenci.ToList();

            dataGridView1.DataSource = egitmeninOgrencileri;

            // Egitmen seciliegt = comboBox1.SelectedValue as Egitmen;
            //dataGridView1.DataSource = db.Egitmenler.Find(seciliegt.EgitmenID).Ogrenci.ToList();


        }
    }
}
