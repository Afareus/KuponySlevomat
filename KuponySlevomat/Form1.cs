using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuponySlevomat.Busines;
using KuponySlevomat.Model;
using KuponySlevomat.Queries;
using KuponySlevomat.TicketsData;

namespace KuponySlevomat {
    public partial class Form1 : Form {

        private TicketController ticketController;
        private WriterReaderTxt writeReaderTxt;

        public Form1() {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData() {
            CBoxCompanySearch.Items.Insert(0, "Vše");
            CBoxCompanySearch.Items.Insert(1, "Sodexo");
            CBoxCompanySearch.Items.Insert(2, "UP");
            CBoxCompanySearch.Items.Insert(3, "Edenred");
            CBoxCompanySearch.Items.Insert(4, "Moje Stravenka");
            CBoxCompanySearch.SelectedIndex = 0;
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

        private void dateTimePickerAcceptedDay_CloseUp(object sender, EventArgs e) {
            txbEAN.Focus();
        }


        private void txbEAN_Enter(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {

                ConvertToCzKeyboard();

                if (IsCorectEAN()) {
                    if (!DuplicateTicket()) {
                        AddTicket();
                    } else {
                        MessageBox.Show("Tento kupón jste již vložili!");
                    }
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
                } else if (charEAN[i] == 'ě' || charEAN[i] == 'Ě') {
                    okEAN[i] = '2';
                } else if (charEAN[i] == 'š' || charEAN[i] == 'Š') {
                    okEAN[i] = '3';
                } else if (charEAN[i] == 'č' || charEAN[i] == 'Č') {
                    okEAN[i] = '4';
                } else if (charEAN[i] == 'ř' || charEAN[i] == 'Ř') {
                    okEAN[i] = '5';
                } else if (charEAN[i] == 'ž' || charEAN[i] == 'Ž') {
                    okEAN[i] = '6';
                } else if (charEAN[i] == 'ý' || charEAN[i] == 'Ý') {
                    okEAN[i] = '7';
                } else if (charEAN[i] == 'á' || charEAN[i] == 'Á') {
                    okEAN[i] = '8';
                } else if (charEAN[i] == 'í' || charEAN[i] == 'Í') {
                    okEAN[i] = '9';
                } else if (charEAN[i] == 'é' || charEAN[i] == 'É') {
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

            if (ean.Length != 22 && ean.Length != 24 && ean.Length != 32) {
                ok = false;
            }

            if (ean.Contains("x")) {
                ok = false;
            }

            return ok;
        }

        private bool DuplicateTicket() {
            Ticket ticket = null;
            ticket = ticketController.Tickets.FirstOrDefault(tic => tic.Ean.Equals(txbEAN.Text.Trim()));
            if (ticket != null) {
                return true;
            } else {
                return false;
            }
        }

        private void AddTicket() {
            if (CBoxCompany.SelectedIndex == 0) {
                if (txbEAN.Text.Trim().Length != 24 || !ticketController.AddSodexoTicketToList(txbEAN.Text.Trim(), dateTimePickerAcceptedDay.Value.ToString("yyyy-MM-dd"))) {
                    MessageBox.Show("Nelze načíst všechna data z kupónu. Zkontrolujte výběr firmy.");
                } else {
                    ShowInfo();
                }
            } else if (CBoxCompany.SelectedIndex == 1) {
                if (txbEAN.Text.Trim().Length != 24 || !ticketController.AddUpTicketToList(txbEAN.Text.Trim(), dateTimePickerAcceptedDay.Value.ToString("yyyy-MM-dd"))) {
                    MessageBox.Show("Nelze načíst všechna data z kupónu. Zkontrolujte výběr firmy.");
                } else {
                    ShowInfo();
                }
            } else if (CBoxCompany.SelectedIndex == 2) {
                if (txbEAN.Text.Trim().Length != 32 || !ticketController.AddEdenredTicketToList(txbEAN.Text.Trim(), dateTimePickerAcceptedDay.Value.ToString("yyyy-MM-dd"))) {
                    MessageBox.Show("Nelze načíst všechna data z kupónu. Zkontrolujte výběr firmy.");
                } else {
                    ShowInfo();
                }
            } else if (CBoxCompany.SelectedIndex == 3) {
                if (txbEAN.Text.Trim().Length != 22 || !ticketController.AddMojeStravenkaTicketToList(txbEAN.Text.Trim(), dateTimePickerAcceptedDay.Value.ToString("yyyy-MM-dd"))) {
                    MessageBox.Show("Nelze načíst všechna data z kupónu. Zkontrolujte výběr firmy.");
                } else {
                    ShowInfo();
                }
            } else {
                MessageBox.Show("Nevybral jsi Firmu");
            }
        }

        private void ShowInfo() {
            listBoxAddedTickets.Items.Clear();
            listBoxAddedTickets.Items.AddRange(ReturnAllAddedTickets());

            lblCountTickets.Text = ticketController.Tickets.Count.ToString();

            int totalValue = 0;
            foreach (Ticket tic in ReturnAllAddedTickets()) {
                totalValue += Int32.Parse(tic.Value);
            }
            lblTotalValue.Text = totalValue.ToString() + " Kč";
        }

        private Ticket[] ReturnAllAddedTickets() {
            return ticketController.Tickets.ToArray();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (ticketController.SentAddedTicketToSave()) {
                MessageBox.Show("Uloženo");
                ticketController.Tickets.Clear();
                ShowInfo();
            } else {
                MessageBox.Show(" Něco se nepovedlo. \n Zkontrolujte v nastavení cestu k databázi.");
            }
        }

        private void btnOdebratTicket_Click(object sender, EventArgs e) {
            int indexOfTicket = listBoxAddedTickets.SelectedIndex;
            if (indexOfTicket >= 0) {
                ticketController.Tickets.RemoveAt(indexOfTicket);
                ShowInfo();
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
                MessageBox.Show("Cesta k databázi byla uložena");
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

        bool showCompleteList = false;            // nastavuje se při zobrazení panelu 4. (true jen když je zobrazen panel pro kompletní výpis kupónů)

        private void btnSearch_Click(object sender, EventArgs e) {
            listBoxShowSavedTickets.Items.Clear();

            try {
                Ticket[] loadedTickets = ticketController.databaseQueries.GetTickets(CBoxCompanySearch.SelectedIndex, dateTimePickerFrom, dateTimePickerTo);

                if (showCompleteList) {
                    listBoxShowSavedTickets.Items.AddRange(loadedTickets);                      // pro 100k stravenek trvá cca 30s !!!
                } else {
                    txbSummaryInfo.Text = Environment.NewLine + "\t     Poukázky přijaté za období od " + dateTimePickerFrom.Value.ToString("dd.MM.yyyy") + " do " + dateTimePickerTo.Value.ToString("dd.MM.yyyy") + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    txbSummaryInfo.Text += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", "Hodnota", "Kusy", "Celkem") + Environment.NewLine;
                    txbSummaryInfo.Text += "__________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    txbSummaryInfo.Text += ticketController.SummaryInfo(loadedTickets);          // METODA PRO VÝPIS SOUHRNU
                }

                List<string> summaryText = new List<string>();
                int totalValue = 0;
                foreach (Ticket tic in loadedTickets) {
                    totalValue += Int32.Parse(tic.Value);
                }

                lblTotalValueFromDB.Text = totalValue.ToString() + " Kč";
                lblTotalCountFromDB.Text = loadedTickets.Count().ToString();
            } catch (Microsoft.Data.Sqlite.SqliteException) {
                MessageBox.Show(" Něco se nepovedlo. \n Zkontrolujte v nastavení cestu k databázi.");
            }
        }

        private void menuAddTickets_Click(object sender, EventArgs e) {
            panel1.BringToFront();
            lblVarovani.Visible = false;
        }

        private void menuSettings_Click(object sender, EventArgs e) {
            panel3.BringToFront();
            lblVarovani.Visible = false;
        }

        private void detailniVypisToolStripMenuItem_Click(object sender, EventArgs e) {
            panel2.BringToFront();
            panel4.BringToFront();
            lblVarovani.Visible = true;
            showCompleteList = true;
        }

        private void SouhrnToolStripMenuItem_Click(object sender, EventArgs e) {
            panel2.BringToFront();
            panel5.BringToFront();
            lblVarovani.Visible = false;
            showCompleteList = false;
        }

        private void CBoxCompanySearch_SelectedIndexChanged(object sender, EventArgs e) {
            if (((ComboBox)sender).SelectedIndex == 1) {
                cBoxTypes.Items.Clear();
                cBoxTypes.Items.Add("Vše");
                cBoxTypes.Items.AddRange(TicketsTypes.SodexoTypes.ToArray());
                cBoxTypes.SelectedIndex = 0;
            } else if (((ComboBox)sender).SelectedIndex == 2) {
                cBoxTypes.Items.Clear();
                cBoxTypes.Items.Add("Vše");
                cBoxTypes.Items.AddRange(TicketsTypes.UpTypes.ToArray());
                cBoxTypes.SelectedIndex = 0;
            } else if (((ComboBox)sender).SelectedIndex == 3) {
                cBoxTypes.Items.Clear();
                cBoxTypes.Items.Add("Vše");
                cBoxTypes.Items.AddRange(TicketsTypes.EdenredTypes.ToArray());
                cBoxTypes.SelectedIndex = 0;
            } else {
                cBoxTypes.Items.Clear();
                cBoxTypes.Text = string.Empty;
            }
        }
    }
}
