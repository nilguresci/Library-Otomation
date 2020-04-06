using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOtomation
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapAra kitapAra = new KitapAra();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_KisiArama form_KisiArama = new Form_KisiArama();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OduncVerilen oduncVerilen = new OduncVerilen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
        }
    }
}
