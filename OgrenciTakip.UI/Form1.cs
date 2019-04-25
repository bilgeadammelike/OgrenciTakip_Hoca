using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciTakip.DAL;

namespace OgrenciTakip.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();

        }

        private void Yukle()
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            OgrenciTakipDBEntities db = new OgrenciTakipDBEntities();
            foreach (Ogretmen item in db.Ogretmen.Where(a => a.AktifMi == true/* && a.OgretmenID==5*/).Take(10).ToList())
            {
                //listBox1.Items.Add(item.Zumre.Adi);
                listBox1.Items.Add(item);
            }
            foreach (var item in db.Zumre.ToList())
            {
                comboBox1.Items.Add(item);

            }


            //using (OgrenciTakipDBEntities db2 = new OgrenciTakipDBEntities())
            //{
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kaydetme işlemi
            OgrenciTakipDBEntities db = new OgrenciTakipDBEntities();
            
          Ogretmen yeniEklenen=  db.Ogretmen.Add(new Ogretmen()
            {
                AdiSoyadi=textBox1.Text,
                ZumreID=(comboBox1.SelectedItem as Zumre).ZumreID,
                AktifMi=true

            });
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("eklendi..");
                Yukle();
            }
            else
            {
                MessageBox.Show("hata var..");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogretmen silinecekOgretmen = listBox1.SelectedItem as Ogretmen;

            OgrenciTakipDBEntities db = new OgrenciTakipDBEntities();

         Ogretmen eskiVeri=   db.Ogretmen.Where(a=>a.OgretmenID==silinecekOgretmen.OgretmenID).SingleOrDefault();
            db.Ogretmen.Remove(eskiVeri);
            db.SaveChanges();


        }
    }
}
