using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaVızeOdevı
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap_İşlemleri form = new Kitap_İşlemleri();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emanet_İşlemleri form = new Emanet_İşlemleri();
            form.Show();

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void UyeIslemlerı_Click(object sender, EventArgs e)
        {
            UyeIslemleri1 form = new UyeIslemleri1();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
