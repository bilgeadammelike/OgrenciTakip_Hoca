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
            OgrenciTakipDBEntities db = new OgrenciTakipDBEntities();
            foreach (Ogretmen item in db.Ogretmen.Where(a=>a.AktifMi==true/* && a.OgretmenID==5*/).Take(10).ToList())
            {
                //listBox1.Items.Add(item.Zumre.Adi);
                listBox1.Items.Add(item);

            }
        }
    }
}
