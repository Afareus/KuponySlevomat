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
    
        public string ZadaneHeslo { get; private set; }

        public PasswordForm() {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (textBoxPassword.Text == "kapitan") {
                ZadaneHeslo = textBoxPassword.Text;
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
