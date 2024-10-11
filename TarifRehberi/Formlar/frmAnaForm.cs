using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarifRehberi.Formlar
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        //tarif listesi butonu
        private void tarifListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // frmTarifListesiForm'ün zaten açık olup olmadığını kontrol et
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmTarifListesiForm) // Eğer açık olan form Form4 ise
                {
                    form.BringToFront(); // Formu öne getir
                    return; // Fonksiyondan çık
                }
            }

            frmTarifListesiForm tarifListesiForm = new frmTarifListesiForm();
            tarifListesiForm.MdiParent = this; // Alt formun MDI ana formu olarak ayarlanması
            tarifListesiForm.Show(); // Alt formu göster
        }

        //tarif ekle butonu
        private void tarifEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // frmTarifListesiForm'ün zaten açık olup olmadığını kontrol et
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmTarifEkleForm) // Eğer açık olan form Form4 ise
                {
                    form.BringToFront(); // Formu öne getir
                    return; // Fonksiyondan çık
                }
            }

            frmTarifEkleForm tarifEkleForm = new frmTarifEkleForm();
            tarifEkleForm.MdiParent = this; // Alt formun MDI ana formu olarak ayarlanması
            tarifEkleForm.Show(); // Alt formu göster
        }
    }
}
