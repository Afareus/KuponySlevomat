using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuponySlevomat {

    public partial class PasswordForm : Form {

        string EAN;

        public PasswordForm(string ean) {
            InitializeComponent();
            EAN = ean;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (textBoxPassword.Text == "kapitan") {
                DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("Nepltné heslo. Zkuste to znovu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
