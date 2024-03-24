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
    public partial class Emanet_İşlemleri : Form
    {
        public Emanet_İşlemleri()
        {
            InitializeComponent();
        }

        private void TeslımEt_Click(object sender, EventArgs e)
        {
            
            int degisken=Convert.ToInt32(CezaBox.Text);
            if(degisken !=  0) 
            {
                MessageBox.Show("Cezanızı var ise ödemeden kitabı teslim edemezsiniz.", "DİKKAT",
                                                                                         MessageBoxButtons.OK,
                                                                                         MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Kitabınız Teslim edildi.");
            }
        }
    }
}
