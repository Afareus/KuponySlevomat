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
using KuponySlevomat.Business;
using KuponySlevomat.Model;
using KuponySlevomat.Queries;
using KuponySlevomat.TicketsData;

namespace KuponySlevomat {
    public partial class Form1 : Form {

        private TicketController ticketController;
        private ConfigOperator writeReaderTxt;

        public Form1() {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData() {
            CBoxCompanySearch.Items.Insert(0, "Vše");
            CBoxCompanySearch.Items.Insert(1, "Sodexo");
            CBoxCompanySearch.Items.Insert(2, "Up");
            CBoxCompanySearch.Items.Insert(3, "Edenred");
            CBoxCompanySearch.Items.Insert(4, "Moje Stravenka");
            CBoxCompanySearch.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e) {
            writeReaderTxt = new ConfigOperator();
            ticketController = new TicketController(writeReaderTxt.ReadText());
            txbPath.Text = writeReaderTxt.ReadText();
            txbEAN.Focus();
        }


        //______________________________________________________________________________________________________________________________________
        //_______________________________________________________ PANEL PŘIDAT POUKÁZKY ________________________________________________________
        //______________________________________________________________________________________________________________________________________


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
                        System.Media.SystemSounds.Hand.Play(); 
                        MessageBox.Show("Tento kupón jste již vložili!");
                    }
                } else {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Neznámý EAN kód");
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

        private void ShowInfo(List<Ticket> tickets)
        {
            listBoxAddedTickets.Items.Clear();
            listBoxAddedTickets.Items.AddRange(tickets.ToArray());

            lblCountTickets.Text = tickets.Count.ToString();

            int totalValue = 0;
            foreach (Ticket tic in tickets)
            {
                totalValue += Int32.Parse(tic.Value);
            }
            lblTotalValue.Text = totalValue.ToString() + " Kč";
        }

        private Ticket[] ReturnAllAddedTickets() {
            return ticketController.Tickets.ToArray();
        }

        int saveStatus = 1;  // 1 - první klik na tlačítko uložit, 2 - klik na tlačítko uložit po zobrazení pouze stravenek bez duplicit v databázi
        private void btnSave_Click(object sender, EventArgs e) {

            if (saveStatus == 1)
            {
                if (ticketController.Tickets.Count > 0) {

                    bool containTicketsDuplicate = ticketController.ContainTicketsDuplicate();

                    if (containTicketsDuplicate == false)
                    {
                        bool saved = ticketController.SentAllTicketsToSave();
                        if (saved)
                        {
                            MessageBox.Show("Uloženo");
                            ticketController.Tickets.Clear();
                            ShowInfo();
                        }
                        else
                        {
                            MessageBox.Show(" Něco se nepovedlo. \n Zkontrolujte v nastavení cestu k databázi.");
                        }
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Některé kupóny již jsou v databázi uloženy. \n \n " +
                            " Chcete zobrazit seznam bez duplicit? Stiskněte 'Ano' \n " +
                            " Chcete zobrazit jen duplicity? Stiskněte 'Ne'", "Duplicity", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            listBoxAddedTickets.Items.Clear();
                            listBoxAddedTickets.Items.AddRange(ticketController.NewTicketsOnly.ToArray());
                            ShowInfo(ticketController.NewTicketsOnly);

                            btnBackToShowAllTickets.Visible = true;
                            lblViewInfo.Visible = true;
                            lblViewInfo.Text = "Bez duplicit";
                            btnDeleteAll.Visible = false;
                            btnOdebratTicket.Visible = false;
                            label4.Visible = false;
                            label12.Visible = false;

                            saveStatus = 2;
                        }
                        else if (dr == DialogResult.No)
                        {
                            listBoxAddedTickets.Items.Clear();
                            listBoxAddedTickets.Items.AddRange(ticketController.DuplicatedTicketsOnly.ToArray());
                            ShowInfo(ticketController.DuplicatedTicketsOnly);

                            btnBackToShowAllTickets.Visible = true;
                            lblViewInfo.Visible = true;
                            lblViewInfo.Text = "Duplicity";
                            btnDeleteAll.Visible = false;
                            btnOdebratTicket.Visible = false;
                            label4.Visible = false;
                            label12.Visible = false;

                            saveStatus = 3;
                        }
                    }
                }
            }
            else if (saveStatus == 2)
            {
                if (ticketController.Tickets.Count > 0)
                {
                    bool saved = ticketController.SentNewOnlyTicketsToSave();
                    if (saved)
                    {
                        MessageBox.Show("Uloženo");
                        ticketController.Tickets.Clear();
                        ticketController.NewTicketsOnly.Clear();
                        ticketController.DuplicatedTicketsOnly.Clear();
                        saveStatus = 1;
                        ShowInfo();
                    }
                    else
                    {
                        saveStatus = 1;
                        MessageBox.Show(" Něco se nepovedlo. \n Zkontrolujte v nastavení cestu k databázi.");
                    }
                }
            }
            else if (saveStatus == 3)
            {
                MessageBox.Show("Nelze uložit duplicity!");
            }



        }

        private void btnOdebratTicket_Click(object sender, EventArgs e) {
            int indexOfTicket = listBoxAddedTickets.SelectedIndex;
            if (indexOfTicket >= 0) {
                ticketController.Tickets.RemoveAt(indexOfTicket);
                ShowInfo();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e) {
            ticketController.Tickets.Clear();
            ShowInfo();
        }


        //______________________________________________________________________________________________________________________________________
        //________________________________________________________ PANEL NASTAVENÍ _____________________________________________________________
        //______________________________________________________________________________________________________________________________________


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

        //______________________________________________________________________________________________________________________________________
        //_______________________________________________________ PANEL SOUHRNŮ POUKÁZEK _______________________________________________________
        //______________________________________________________________________________________________________________________________________

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

        bool showCompleteList = false;            // nastavuje se při zobrazení panelu 4. (true jen když je zobrazen panel pro kompletní výpis kupónů)

        private void btnSearch_Click(object sender, EventArgs e) {
            listBoxShowSavedTickets.Items.Clear();
            try {
                Ticket[] unsortedloadedTickets = ticketController.databaseQueries.GetTickets(CBoxCompanySearch.SelectedIndex, dateTimePickerFrom, dateTimePickerTo);
                Ticket[] loadedTickets = unsortedloadedTickets.OrderBy(x => int.Parse(x.Value)).ToArray();


                if (showCompleteList) {
                    listBoxShowSavedTickets.Items.AddRange(loadedTickets);                                  // pro 100k stravenek trvá cca 30s !!!
                } else {
                    ShowPeriodInfo();

                    if (CBoxCompanySearch.Text == TicketsCompanies.Companies[0]) {                          // pokud je vybrána firma SODEXO 
                        ShowSodexoInfo(loadedTickets);
                    } else if (CBoxCompanySearch.Text == TicketsCompanies.Companies[1]) {                   // nebo Up
                        ShowUpInfo(loadedTickets);
                    } else if (CBoxCompanySearch.Text == TicketsCompanies.Companies[2]) {
                        ShowEdenredInfo(loadedTickets);
                    } else if (CBoxCompanySearch.Text == TicketsCompanies.Companies[3]) {
                        ShowMojeStravenkaInfo(loadedTickets);
                    } else {
                        ShowSodexoInfo(loadedTickets);
                        ShowUpInfo(loadedTickets);
                        ShowEdenredInfo(loadedTickets);
                        ShowMojeStravenkaInfo(loadedTickets);
                        ShowGeneralInfo(loadedTickets);
                    }
                    btnPrint.Visible = true;
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

        private void ShowPeriodInfo() {
            txbSummaryInfo.Text = Environment.NewLine + Environment.NewLine + "\t\t       Poukázky přijaté za období od " + dateTimePickerFrom.Value.ToString("dd.MM.yyyy") + " do " + dateTimePickerTo.Value.ToString("dd.MM.yyyy");
        }

        private void ShowMojeStravenkaInfo(Ticket[] loadedTickets) {
            txbSummaryInfo.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            txbSummaryInfo.Text += "\t" + TicketsCompanies.Companies[3] + Environment.NewLine + Environment.NewLine;               // vypíše Moje Stravenka

            txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Hodnota", "Kusy", "Celkem") + Environment.NewLine;
            txbSummaryInfo.Text += "\t__________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            List<Array> TickestByTypes = new List<Array>();                                     // stravenky uložené podle typů  (vždy pro jednu firmu)

            TickestByTypes.Add(loadedTickets.Where(t => t.Company == TicketsCompanies.Companies[3]).ToArray());

            string typPoukazky = "";
            string pocetPoukazekProTyp = TickestByTypes[0].Length.ToString();
            string soucetHodnotProTyp = ((Ticket[])TickestByTypes[0]).Sum(t => int.Parse(t.Value)).ToString();
            var SeskupenoPodleHodot = ((Ticket[])TickestByTypes[0]).GroupBy(t => t.Value);

            if (TickestByTypes[0].Length != 0) {
                txbSummaryInfo.Text += string.Format("\t\t") + typPoukazky + Environment.NewLine;

                foreach (var group in SeskupenoPodleHodot) {
                    txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", int.Parse(group.Key), group.Count(), int.Parse(group.Key) * group.Count()) + Environment.NewLine;
                }

                txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "-------", "--------", "-----------") + Environment.NewLine;
                txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem:", pocetPoukazekProTyp, soucetHodnotProTyp) + Environment.NewLine;
                txbSummaryInfo.Text += "\t    ---------------------------------------------------------------------------    " + Environment.NewLine;

                txbSummaryInfo.Text += Environment.NewLine + "\t\t     Celkem " + pocetPoukazekProTyp + " kusů v celkové hodnotě " + soucetHodnotProTyp + " Kč." + Environment.NewLine;
                txbSummaryInfo.Text += "\t__________________________________________________________________________________";
            } else {
                txbSummaryInfo.Text += "\t\t Nenalezeny žádné stravenky odpovídající vloženým parametrům." + Environment.NewLine;
                txbSummaryInfo.Text += "     ________________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
        }

        private void ShowEdenredInfo(Ticket[] loadedTickets) {
            txbSummaryInfo.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            txbSummaryInfo.Text += "\t" + TicketsCompanies.Companies[2] + Environment.NewLine + Environment.NewLine;               // vypíše Edenred

            txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Hodnota", "Kusy", "Celkem") + Environment.NewLine;
            txbSummaryInfo.Text += "\t__________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            List<Array> TickestByTypes = new List<Array>();                                     // stravenky uložené podle typů  (vždy pro jednu firmu)

            if (cBoxTypes.SelectedIndex == 0 || CBoxCompanySearch.SelectedIndex == 0) {               // když josu vybrány všechny typy , nebo všechny společnosti

                for (int i = 0; i < TicketsTypes.EdenredTypes.Count; i++) {                     // projede všechny typy Up stravanek
                    TickestByTypes.Add(loadedTickets.Where(t => t.Company == TicketsCompanies.Companies[2] && t.Type == TicketsTypes.EdenredTypes[i]).ToArray());
                }

                bool emptySelect = true;
                int pocetCelkem = 0;
                int soucetCelkem = 0;

                for (int i = 0; i < TickestByTypes.Count; i++) {
                    string typPoukazky = TicketsTypes.EdenredTypes[i];
                    int pocetPoukazekProTyp = TickestByTypes[i].Length;
                    int soucetHodnotProTyp = ((Ticket[])TickestByTypes[i]).Sum(t => int.Parse(t.Value));
                    var SeskupenoPodleHodot = ((Ticket[])TickestByTypes[i]).GroupBy(t => t.Value);

                    pocetCelkem += pocetPoukazekProTyp;
                    soucetCelkem += soucetHodnotProTyp;

                    if (TickestByTypes[i].Length != 0) {
                        txbSummaryInfo.Text += string.Format("\t\t") + typPoukazky + Environment.NewLine;
                        emptySelect = false;

                        foreach (var group in SeskupenoPodleHodot) {
                            txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", int.Parse(group.Key), group.Count(), int.Parse(group.Key) * group.Count()) + Environment.NewLine;
                        }

                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "-------", "--------", "-----------") + Environment.NewLine;
                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem:", pocetPoukazekProTyp, soucetHodnotProTyp) + Environment.NewLine;
                        txbSummaryInfo.Text += "\t    ---------------------------------------------------------------------------    " + Environment.NewLine;
                    }

                }

                if (emptySelect) {
                    txbSummaryInfo.Text += "\t\t Nenalezeny žádné stravenky odpovídající vloženým parametrům." + Environment.NewLine;
                    txbSummaryInfo.Text += "     ________________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                } else {
                    txbSummaryInfo.Text += Environment.NewLine + "\t\t     Celkem " + pocetCelkem + " kusů v celkové hodnotě " + soucetCelkem + " Kč." + Environment.NewLine;
                    txbSummaryInfo.Text += "\t__________________________________________________________________________________";
                }

            } else {
                TickestByTypes.Add(loadedTickets.Where(t => t.Company == TicketsCompanies.Companies[2] && t.Type == TicketsTypes.EdenredTypes[cBoxTypes.SelectedIndex - 1]).ToArray());

                string typPoukazky = TicketsTypes.EdenredTypes[cBoxTypes.SelectedIndex - 1];
                string pocetPoukazekProTyp = TickestByTypes[0].Length.ToString();
                string soucetHodnotProTyp = ((Ticket[])TickestByTypes[0]).Sum(t => int.Parse(t.Value)).ToString();
                var SeskupenoPodleHodot = ((Ticket[])TickestByTypes[0]).GroupBy(t => t.Value);

                if (TickestByTypes[0].Length != 0) {
                    txbSummaryInfo.Text += string.Format("\t\t") + typPoukazky + Environment.NewLine;

                    foreach (var group in SeskupenoPodleHodot) {
                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", int.Parse(group.Key), group.Count(), int.Parse(group.Key) * group.Count()) + Environment.NewLine;
                    }

                    txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "-------", "--------", "-----------") + Environment.NewLine;
                    txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem:", pocetPoukazekProTyp, soucetHodnotProTyp) + Environment.NewLine;
                    txbSummaryInfo.Text += "\t    ---------------------------------------------------------------------------    " + Environment.NewLine;
                } else {
                    txbSummaryInfo.Text += "\t\t Nenalezeny žádné stravenky odpovídající vloženým parametrům.";
                }
            }
        }

        private void ShowUpInfo(Ticket[] loadedTickets) {
            txbSummaryInfo.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            txbSummaryInfo.Text += "\t" + TicketsCompanies.Companies[1] + Environment.NewLine + Environment.NewLine;               // jen vypíše Up

            txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Hodnota", "Kusy", "Celkem") + Environment.NewLine;
            txbSummaryInfo.Text += "\t__________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            List<Array> TickestByTypes = new List<Array>();                                     // stravenky uložené podle typů  (vždy pro jednu firmu)

            if (cBoxTypes.SelectedIndex == 0 || CBoxCompanySearch.SelectedIndex == 0) {               // když josu vybrány všechny typy , nebo všechny společnosti

                for (int i = 0; i < TicketsTypes.UpTypes.Count; i++) {                      // projede všechny typy Up stravanek
                    TickestByTypes.Add(loadedTickets.Where(t => t.Company == TicketsCompanies.Companies[1] && t.Type == TicketsTypes.UpTypes[i]).ToArray());
                }

                bool emptySelect = true;
                int pocetCelkem = 0;
                int soucetCelkem = 0;

                for (int i = 0; i < TickestByTypes.Count; i++) {
                    string typPoukazky = TicketsTypes.UpTypes[i];
                    int pocetPoukazekProTyp = TickestByTypes[i].Length;
                    int soucetHodnotProTyp = ((Ticket[])TickestByTypes[i]).Sum(t => int.Parse(t.Value));
                    var SeskupenoPodleHodot = ((Ticket[])TickestByTypes[i]).GroupBy(t => t.Value);

                    pocetCelkem += pocetPoukazekProTyp;
                    soucetCelkem += soucetHodnotProTyp;

                    if (TickestByTypes[i].Length != 0) {
                        txbSummaryInfo.Text += string.Format("\t\t") + typPoukazky + Environment.NewLine;
                        emptySelect = false;

                        foreach (var group in SeskupenoPodleHodot) {
                            txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", int.Parse(group.Key), group.Count(), int.Parse(group.Key) * group.Count()) + Environment.NewLine;
                        }

                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "-------", "--------", "-----------") + Environment.NewLine;
                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem:", pocetPoukazekProTyp, soucetHodnotProTyp) + Environment.NewLine;
                        txbSummaryInfo.Text += "\t    ---------------------------------------------------------------------------    " + Environment.NewLine;
                    }

                }

                if (emptySelect) {
                    txbSummaryInfo.Text += "\t\t Nenalezeny žádné stravenky odpovídající vloženým parametrům." + Environment.NewLine;
                    txbSummaryInfo.Text += "     ________________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                } else {
                    txbSummaryInfo.Text += Environment.NewLine + "\t\t     Celkem " + pocetCelkem + " kusů v celkové hodnotě " + soucetCelkem + " Kč." + Environment.NewLine;
                    txbSummaryInfo.Text += "\t__________________________________________________________________________________";
                }


            } else {
                TickestByTypes.Add(loadedTickets.Where(t => t.Company == TicketsCompanies.Companies[1] && t.Type == TicketsTypes.UpTypes[cBoxTypes.SelectedIndex - 1]).ToArray());

                string typPoukazky = TicketsTypes.UpTypes[cBoxTypes.SelectedIndex - 1];
                string pocetPoukazekProTyp = TickestByTypes[0].Length.ToString();
                string soucetHodnotProTyp = ((Ticket[])TickestByTypes[0]).Sum(t => int.Parse(t.Value)).ToString();
                var SeskupenoPodleHodot = ((Ticket[])TickestByTypes[0]).GroupBy(t => t.Value);

                if (TickestByTypes[0].Length != 0) {
                    txbSummaryInfo.Text += string.Format("\t\t") + typPoukazky + Environment.NewLine;

                    foreach (var group in SeskupenoPodleHodot) {
                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", int.Parse(group.Key), group.Count(), int.Parse(group.Key) * group.Count()) + Environment.NewLine;
                    }

                    txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "-------", "--------", "-----------") + Environment.NewLine;
                    txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem:", pocetPoukazekProTyp, soucetHodnotProTyp) + Environment.NewLine;
                    txbSummaryInfo.Text += "\t    ---------------------------------------------------------------------------    " + Environment.NewLine;
                } else {
                    txbSummaryInfo.Text += "\t\t Nenalezeny žádné stravenky odpovídající vloženým parametrům.";
                }
            }
        }

        private void ShowSodexoInfo(Ticket[] loadedTickets) {
            txbSummaryInfo.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            txbSummaryInfo.Text += "\t" + TicketsCompanies.Companies[0] + Environment.NewLine + Environment.NewLine;               // vypíše Sodexo 

            txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Hodnota", "Kusy", "Celkem") + Environment.NewLine;
            txbSummaryInfo.Text += "\t__________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            List<Array> TickestByTypes = new List<Array>();                                     // stravenky uložené podle typů  (vždy pro jednu firmu)

            if (cBoxTypes.SelectedIndex == 0 || CBoxCompanySearch.SelectedIndex == 0) {         // když josu vybrány všechny typy , nebo všechny společnosti

                for (int i = 0; i < TicketsTypes.SodexoTypes.Count; i++) {                      // projede všechny typy Sodexo stravanek
                    TickestByTypes.Add(loadedTickets.Where(t => t.Company == TicketsCompanies.Companies[0] && t.Type == TicketsTypes.SodexoTypes[i]).ToArray());
                }

                bool emptySelect = true;
                int pocetCelkem = 0;
                int soucetCelkem = 0;

                for (int i = 0; i < TickestByTypes.Count; i++) {
                    string typPoukazky = TicketsTypes.SodexoTypes[i];
                    int pocetPoukazekProTyp = TickestByTypes[i].Length;
                    int soucetHodnotProTyp = ((Ticket[])TickestByTypes[i]).Sum(t => int.Parse(t.Value));
                    var SeskupenoPodleHodot = ((Ticket[])TickestByTypes[i]).GroupBy(t => t.Value);

                    pocetCelkem += pocetPoukazekProTyp;
                    soucetCelkem += soucetHodnotProTyp;

                    if (TickestByTypes[i].Length != 0) {
                        txbSummaryInfo.Text += string.Format("\t\t") + typPoukazky + Environment.NewLine;
                        emptySelect = false;

                        foreach (var group in SeskupenoPodleHodot) {
                            txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", int.Parse(group.Key), group.Count(), int.Parse(group.Key) * group.Count()) + Environment.NewLine;
                        }

                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "-------", "--------", "-----------") + Environment.NewLine;
                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem:", pocetPoukazekProTyp, soucetHodnotProTyp) + Environment.NewLine;
                        txbSummaryInfo.Text += "\t    ---------------------------------------------------------------------------    " + Environment.NewLine;
                    }

                }

                if (emptySelect) {
                    txbSummaryInfo.Text += "\t\t Nenalezeny žádné stravenky odpovídající vloženým parametrům." + Environment.NewLine;
                    txbSummaryInfo.Text += "     ________________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                } else {
                    txbSummaryInfo.Text += Environment.NewLine + "\t\t     Celkem " + pocetCelkem + " kusů v celkové hodnotě " + soucetCelkem + " Kč." + Environment.NewLine;
                    txbSummaryInfo.Text += "\t__________________________________________________________________________________";
                }

                
            } else {
                TickestByTypes.Add(loadedTickets.Where(t => t.Company == TicketsCompanies.Companies[0] && t.Type == TicketsTypes.SodexoTypes[cBoxTypes.SelectedIndex - 1]).ToArray());

                string typPoukazky = TicketsTypes.SodexoTypes[cBoxTypes.SelectedIndex - 1];
                string pocetPoukazekProTyp = TickestByTypes[0].Length.ToString();
                string soucetHodnotProTyp = ((Ticket[])TickestByTypes[0]).Sum(t => int.Parse(t.Value)).ToString();
                var SeskupenoPodleHodot = ((Ticket[])TickestByTypes[0]).GroupBy(t => t.Value);

                if (TickestByTypes[0].Length != 0) {
                    txbSummaryInfo.Text += string.Format("\t\t") + typPoukazky + Environment.NewLine;

                    foreach (var group in SeskupenoPodleHodot) {
                        txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", int.Parse(group.Key), group.Count(), int.Parse(group.Key) * group.Count()) + Environment.NewLine;
                    }

                    txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "-------", "--------", "-----------") + Environment.NewLine;
                    txbSummaryInfo.Text += string.Format("\t\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem:", pocetPoukazekProTyp, soucetHodnotProTyp) + Environment.NewLine;
                    txbSummaryInfo.Text += "\t    ---------------------------------------------------------------------------    " + Environment.NewLine;
                } else {
                    txbSummaryInfo.Text += "\t\t Nenalezeny žádné stravenky odpovídající vloženým parametrům.";
                }
            }
        }

        private void ShowGeneralInfo(Ticket[] loadedTickets) {
            txbSummaryInfo.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            txbSummaryInfo.Text += "\t POČET VŠECH STRAVENEK VE VÝPISU JE " + loadedTickets.Count() + " KUSŮ V CELKOVÉ HODNOTĚ " + loadedTickets.Sum(x => long.Parse(x.Value)) + " KČ.";
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            saveFileDialog1.Title = "Zadejte umístění a název výpisu";
            saveFileDialog1.Filter = "PDF (*.pdf) | *.pdf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "Výpis - Kupony Slevomat " + DateTime.Now.Date.ToShortDateString();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK) {
                PrintOperator printOperator = new PrintOperator(txbSummaryInfo.Text, saveFileDialog1.FileName);
                printOperator.SaveTextToDocument();
                MessageBox.Show("Uloženo");
            }
            
            
        }

        //______________________________________________________________________________________________________________________________________
        //___________________________________________________ PŘEPÍNÁNÍ MEZI POHLEDY (PANELY) __________________________________________________
        //______________________________________________________________________________________________________________________________________

        private void menuAddTickets_Click(object sender, EventArgs e) {
            panel1.BringToFront();
            lblVarovani.Visible = false;
            btnPrint.Visible = false;
        }

        private void menuSettings_Click(object sender, EventArgs e) {
            panel3.BringToFront();
            lblVarovani.Visible = false;
            btnPrint.Visible = false;
        }

        private void detailniVypisToolStripMenuItem_Click(object sender, EventArgs e) {
            panel2.BringToFront();
            panel4.BringToFront();
            lblVarovani.Visible = true;
            showCompleteList = true;
            cBoxTypes.Visible = false;
            labTypes.Visible = false;
            lblTotalCountFromDB.Text = "0";
            lblTotalValueFromDB.Text = "0";
            listBoxShowSavedTickets.Items.Clear();
            btnPrint.Visible = false;
        }

        private void SouhrnToolStripMenuItem_Click(object sender, EventArgs e) {
            panel2.BringToFront();
            panel5.BringToFront();
            lblVarovani.Visible = false;
            showCompleteList = false;
            cBoxTypes.Visible = true;
            labTypes.Visible = true;
            if (txbSummaryInfo.Text == "") {
                btnPrint.Visible = false;
            } else {
                btnPrint.Visible = true;
            }
            
        }

        private void btnBackToShowAllTickets_Click(object sender, EventArgs e)
        {
            listBoxAddedTickets.Items.Clear();
            listBoxAddedTickets.Items.AddRange(ticketController.Tickets.ToArray());
            ShowInfo();

            btnBackToShowAllTickets.Visible = false;
            lblViewInfo.Visible = false;
            btnDeleteAll.Visible = true;
            btnOdebratTicket.Visible = true;
            label4.Visible = true;
            label12.Visible = true;

            saveStatus = 1;
        }
    }
}
