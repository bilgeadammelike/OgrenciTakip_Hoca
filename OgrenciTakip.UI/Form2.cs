using OgrenciTakip.DAL;
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
            db.Sinif.ToList();
        }
    }
}
