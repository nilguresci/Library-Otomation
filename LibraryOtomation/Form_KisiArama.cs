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
    public partial class Form_KisiArama : Form
    {
        public Form_KisiArama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_KisiBilgileri form_KisiBilgileri = new Form_KisiBilgileri();
        }
    }
}
