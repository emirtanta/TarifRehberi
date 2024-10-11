using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static TarifRehberi.Formlar.frmTarifListesiForm;

namespace TarifRehberi.Formlar
{
    public partial class frmTarifGuncelle : Form
    {
        public string UpdatedName { get; private set; }
        public string UpdatedSurname { get; private set; }

        public frmTarifGuncelle(string name, string surname)
        {
            InitializeComponent();
            txtName.Text = name;
            txtSurname.Text = surname;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatedName = txtName.Text;
            UpdatedSurname = txtSurname.Text;
            this.DialogResult = DialogResult.OK; // Formu OK olarak kapat
            this.Close(); // Formu kapat
        }
    }
}
