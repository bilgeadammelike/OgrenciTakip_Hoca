using OgrenciTakip.DAL;
using OgrenciTakip.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakip.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SinifYukle();
        }

        private void SinifYukle()
        {
            OgrenciTakipDBEntities db = new OgrenciTakipDBEntities();
            listBox1.DataSource= db.Sinif.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sinif tiklanilan = listBox1.SelectedItem as Sinif;

            OgrenciTakipDBEntities db = new OgrenciTakipDBEntities();
            var deger = (from sinif in db.Sinif
                        join sinifOgrenci in db.SinifOgrenci on sinif.SinifID equals sinifOgrenci.SinifID
                        join ogrenci in db.Ogrenci on sinifOgrenci.OgrenciID equals ogrenci.OgrenciID
                        select new OgrenciVM() {
                            SinifDegeri =sinif.SinifAdi,
                            OgrenciIsimDegeri =ogrenci.AdiSoyadi /*sinifOgrenci.OgrenciID.ToString()*/

                        }).ToList();



        }
    }
}
