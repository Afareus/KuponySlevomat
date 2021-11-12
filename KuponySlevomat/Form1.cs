using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuponySlevomat.Busines;

namespace KuponySlevomat {
    public partial class Form1 : Form {

        private TicketController ticketController;

        public Form1() {
            InitializeComponent();
            ticketController = new TicketController();
        }

        private void Form1_Load(object sender, EventArgs e) {
            txbEAN.Focus();
        }
        private void CBoxCompany_SelectedIndexChanged(object sender, EventArgs e) {
            txbEAN.Focus();
        }

        private void txbEAN_Enter(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {


                ConvertToCzKeyboard();

                //if (IsCorectEAN()) {
                //} else {
                //    MessageBox.Show("Neplatné zadání");
                //}

                AddTicket();
                
                txbEAN.Text = "";
            }
        }

        private void ConvertToCzKeyboard() {
            char[] charEAN = txbEAN.Text.Trim().ToCharArray();
            char[] okEAN = new char[charEAN.Length];

            for (int i = 0; i < charEAN.Length; i++) {
                if (charEAN[i] == '+') {
                    okEAN[i] = '1';
                } else if (charEAN[i] == 'ě') {
                    okEAN[i] = '2';
                } else if (charEAN[i] == 'š') {
                    okEAN[i] = '3';
                } else if (charEAN[i] == 'č') {
                    okEAN[i] = '4';
                } else if (charEAN[i] == 'ř') {
                    okEAN[i] = '5';
                } else if (charEAN[i] == 'ž') {
                    okEAN[i] = '6';
                } else if (charEAN[i] == 'ý') {
                    okEAN[i] = '7';
                } else if (charEAN[i] == 'á') {
                    okEAN[i] = '8';
                } else if (charEAN[i] == 'í') {
                    okEAN[i] = '9';
                } else if (charEAN[i] == 'é') {
                    okEAN[i] = '0';
                } else if (charEAN[i] > 47 && charEAN[i] < 58) {
                    okEAN[i] = charEAN[i];    
                }
                else {
                    okEAN[i] = 'x';
                }
            }
            txbEAN.Text = new string(okEAN);
        }

        private bool IsCorectEAN() {
            bool ok = true;
            string ean = txbEAN.Text.Trim();

            if (ean.Length != 24 || ean.Length != 32) {
                ok = false;
            }

            if (ean.Contains("x")) {
                ok = false;
            }
            
            return ok;
        }


        private void AddTicket() {
            if (CBoxCompany.SelectedIndex == 0) {
                ticketController.AddSodexoTicketToList(txbEAN.Text.Trim());
                ShowInfo();
            } else if (CBoxCompany.SelectedIndex == 1) {
                ticketController.AddUpTicketToList(txbEAN.Text.Trim());
                ShowInfo();
            } else if (CBoxCompany.SelectedIndex == 2) {
                ticketController.AddEdenredTicketToList(txbEAN.Text.Trim());
                ShowInfo();
            } else {
                MessageBox.Show("Nevybral jsi Firmu");
            }
        }
        private void ShowInfo() {
            int index = ticketController.Tickets.Count - 1;
            lblEAN.Text = ticketController.Tickets[index].Ean;
            lblAdded.Text = ticketController.Tickets[index].Added.ToString();
            lblType.Text = ticketController.Tickets[index].Type;
            lblCompany.Text = ticketController.Tickets[index].Company;
            lblValue.Text = ticketController.Tickets[index].Value.ToString() + " Kč" ;
            if (ticketController.Tickets[index].Validity == 11) {
                lblValidity.Text = "Na šeku";
            } else {
                lblValidity.Text = "31.12.20" + ticketController.Tickets[index].Validity.ToString();
            }
            
            lblCountTickets.Text = ticketController.Tickets.Count.ToString();
        }

    }
}
