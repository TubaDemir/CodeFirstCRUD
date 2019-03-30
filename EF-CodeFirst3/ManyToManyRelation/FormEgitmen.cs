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
    public partial class FormEgitmen : Form
    {
        public FormEgitmen()
        {
            InitializeComponent();
        }
        DBSingleTon db = new DBSingleTon();
        private void FormEgitmen_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            //Anonomys Type
            //dataGridView1.DataSource = db.Egitmenler.Select(x => new
            //{
            //    x.EgitmenID,
            //    x.EgitmenAdi,
            //    x.EgitmenSoyadi
            //}).ToList();

       List<MyEntity> egtListesi  = db.Egitmenler.Select(x => new MyEntity
            {
               Egitmen = x.EgitmenID,
               Ad= x.EgitmenAdi,
               Soyad=  x.EgitmenSoyadi
            }).ToList();

            dataGridView1.DataSource = egtListesi;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Egitmen egt = new Egitmen();
            egt.EgitmenAdi = textBox1.Text;
            egt.EgitmenSoyadi = textBox2.Text;
            db.Egitmenler.Add(egt);
            db.SaveChanges();
            Doldur();
        }
    }
}
