using System;
using System.Windows.Forms;

namespace KuponySlevomat {

    public partial class PasswordForm : Form {

        string EAN;

        public PasswordForm(string ean) {
            InitializeComponent();
            EAN = ean;

            lblEAN.Text = "Pro smazaní poukázky " + ean;
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

        private void PasswordForm_Load(object sender, EventArgs e) {

        }
    }
}
