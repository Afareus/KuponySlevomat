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

        private void txbEAN_Enter(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                AddTicket();

                txbEAN.Text = "";
            }
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
            lblEAN.Text = ticketController.Tickets[ticketController.Tickets.Count - 1].Ean;
            lblAdded.Text = ticketController.Tickets[ticketController.Tickets.Count - 1].Added.ToString();
            lblType.Text = ticketController.Tickets[ticketController.Tickets.Count - 1].Type;

            lblCountTickets.Text = ticketController.Tickets.Count.ToString();
        }
    }
}
