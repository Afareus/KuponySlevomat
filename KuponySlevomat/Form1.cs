using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuponySlevomat.Busines;
using KuponySlevomat.Model;
using KuponySlevomat.Queries;

namespace KuponySlevomat {
    public partial class Form1 : Form {

        private TicketController ticketController;
        private WriterReaderTxt writeReaderTxt;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            writeReaderTxt = new WriterReaderTxt();
            ticketController = new TicketController(writeReaderTxt.ReadText());
            txbPath.Text = writeReaderTxt.ReadText();
            txbEAN.Focus();
        }
        private void CBoxCompany_SelectedIndexChanged(object sender, EventArgs e) {
            txbEAN.Focus();
        }

        private void dateTimePickerAcceptedDay_ValueChanged(object sender, EventArgs e) {
            txbEAN.Focus();
        }

        private void txbEAN_Enter(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {

                ConvertToCzKeyboard();

                if (IsCorectEAN()) {
                    AddTicket();
                } else {
                    MessageBox.Show("Neplatné zadání");
                }


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
                } else {
                    okEAN[i] = 'x';
                }
            }
            txbEAN.Text = new string(okEAN);
        }

        private bool IsCorectEAN() {
            bool ok = true;
            string ean = txbEAN.Text.Trim();

            if (ean.Length != 24 && ean.Length != 32) {
                ok = false;
            }

            if (ean.Contains("x")) {
                ok = false;
            }

            return ok;
        }


        private void AddTicket() {
            if (CBoxCompany.SelectedIndex == 0) {
                if (!ticketController.AddSodexoTicketToList(txbEAN.Text.Trim(), dateTimePickerAcceptedDay.Text) && txbEAN.Text.Trim().Length != 24) {     // k tomu se vrátit ! 
                    MessageBox.Show("Nelze načíst všechna data z kupónu. Zkontrolujte výběr firmy.");
                } else {
                    ShowInfo();
                }
            } else if (CBoxCompany.SelectedIndex == 1) {
                if (!ticketController.AddUpTicketToList(txbEAN.Text.Trim(), dateTimePickerAcceptedDay.Text) && txbEAN.Text.Trim().Length != 24) {     // mají platit obě podmínky
                    MessageBox.Show("Nelze načíst všechna data z kupónu. Zkontrolujte výběr firmy.");
                } else {
                    ShowInfo();
                }
            } else if (CBoxCompany.SelectedIndex == 2) {
                if (!ticketController.AddEdenredTicketToList(txbEAN.Text.Trim(), dateTimePickerAcceptedDay.Text) && txbEAN.Text.Trim().Length != 32) {      // má být and ne or !!!
                    MessageBox.Show("Nelze načíst všechna data z kupónu. Zkontrolujte výběr firmy.");
                } else {
                    ShowInfo();
                }
            } else {
                MessageBox.Show("Nevybral jsi Firmu");
            }
        }
        private void ShowInfo() {
            if (ticketController.Tickets.Count != 0) {
                int index = ticketController.Tickets.Count - 1;
                lblEAN.Text = ticketController.Tickets[index].Ean;
                lblAdded.Text = ticketController.Tickets[index].Added.ToString();
                lblType.Text = ticketController.Tickets[index].Type;
                lblCompany.Text = ticketController.Tickets[index].Company;
                lblValue.Text = ticketController.Tickets[index].Value.ToString() + " Kč";
                if (int.Parse(ticketController.Tickets[index].Validity) == 99) {
                    lblValidity.Text = "Na šeku";
                } else {
                    lblValidity.Text = "31.12.20" + ticketController.Tickets[index].Validity;
                }

                ShowDataInListBox();
            }
        }

        private void ShowDataInListBox() {
            listBoxAddedTickets.Items.Clear();
            listBoxAddedTickets.Items.AddRange(ReturnAllAddedTickets());

            lblCountTickets.Text = ticketController.Tickets.Count.ToString();
        }

        private Ticket[] ReturnAllAddedTickets() {
            return ticketController.Tickets.ToArray();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (ticketController.SentAddedTicketToSave()) {
                MessageBox.Show("Uloženo");
                ticketController.Tickets.Clear();
                ShowDataInListBox();
            } else {
                MessageBox.Show("Něco se nepovedlo");
            }
        }

        private void btnOdebratTicket_Click(object sender, EventArgs e) {
            int indexOfTicket = listBoxAddedTickets.SelectedIndex;
            if (indexOfTicket >= 0) {
                ticketController.Tickets.RemoveAt(indexOfTicket);
                ShowDataInListBox();
            }
        }

        private void btnSetPath_Click(object sender, EventArgs e) {
            openFileDialog1.Title = "Zvolte soubor";
            openFileDialog1.Filter = "Databáze (*.db) | *.db | Databáze (*.db3) | *.db3";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK) {
                writeReaderTxt.WriteText(openFileDialog1.FileName);
                txbPath.Text = writeReaderTxt.ReadText();
                ticketController.databaseQueries.Path = txbPath.Text;
            }
        }

        private void btnCreateDB_Click(object sender, EventArgs e) {
            saveFileDialog1.Title = "Zadejte umístění a název nové databáze";
            saveFileDialog1.Filter = "Databáze (*.db3) | *.db3";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK) {
                if (ticketController.databaseQueries.CreateNewDB(saveFileDialog1.FileName)) {
                    MessageBox.Show("Soubor s databází byl úspěšně vytvořen");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            Ticket[] allTickets = ticketController.databaseQueries.GetAllTickets();

            listBoxShowSavedTickets.Items.Clear();
            listBoxShowSavedTickets.Items.AddRange(allTickets);
        }

        private void buttonTesotvaci_Click(object sender, EventArgs e) {                     // testovací button pro formát Date
            string day = dateTimePickerAcceptedDay.Value.ToString().Substring(0, 2);
            string month = dateTimePickerAcceptedDay.Value.ToString().Substring(3, 2);
            string year = dateTimePickerAcceptedDay.Value.ToString().Substring(6, 4);
            string date = $"{year}-{month}-{day}";
            MessageBox.Show(date);
        }


    }
}
