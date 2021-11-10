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
                
                if (ControlEAN()) {
                AddTicket();
                } else {
                    MessageBox.Show("Neplatné zadání");
                }
                
                txbEAN.Text = "";
            }
        }

        

        private bool ControlEAN() {
            bool ok = true;
            string ean = txbEAN.Text.Trim();

            if (ean.Length != 24 || ean.Length != 32) {
                ok = false;
            }

            foreach (char character in txbEAN.Text.Trim()) {
                if (!(character > 47 && character < 58)) {
                    ok = false;
                }
            }
            return ok;
        }


        private void AddTicket() {
            if (CBoxCompany.SelectedIndex == 0) {
                ticketController.AddSodexoTicketToList(txbEAN.Text.Trim());
                ShowInfo();
            } else if (CBoxCompany.SelectedIndex == 1) {
                //ticketController.AddUpTicketToList(txbEAN.Text.Trim());
                ShowInfo();
            } else if (CBoxCompany.SelectedIndex == 2) {
                //ticketController.AddEdenredTicketToList(txbEAN.Text.Trim());
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
            lblValidity.Text = "31.12.20" + ticketController.Tickets[index].Validity.ToString();
            
            lblCountTickets.Text = ticketController.Tickets.Count.ToString();
        }

    }
}
