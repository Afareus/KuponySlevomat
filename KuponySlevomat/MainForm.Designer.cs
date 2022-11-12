
namespace KuponySlevomat {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbEAN = new System.Windows.Forms.TextBox();
            this.lblCountTickets = new System.Windows.Forms.Label();
            this.CBoxCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxAddedTickets = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOdebratTicket = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAddTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.vypsatSeznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jenSouhrnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackToShowAllTickets = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePickerAcceptedDay = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.labTypes = new System.Windows.Forms.Label();
            this.cBoxTypes = new System.Windows.Forms.ComboBox();
            this.lblVarovani = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSummaryInfo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblTotalValueFromDB = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblTotalCountFromDB = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.listBoxShowSavedTickets = new System.Windows.Forms.ListBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CBoxCompanySearch = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblViewInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbEAN
            // 
            this.txbEAN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbEAN.Location = new System.Drawing.Point(79, 71);
            this.txbEAN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEAN.Multiline = true;
            this.txbEAN.Name = "txbEAN";
            this.txbEAN.Size = new System.Drawing.Size(358, 36);
            this.txbEAN.TabIndex = 0;
            this.txbEAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEAN_Enter);
            // 
            // lblCountTickets
            // 
            this.lblCountTickets.AutoSize = true;
            this.lblCountTickets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCountTickets.Location = new System.Drawing.Point(416, 558);
            this.lblCountTickets.Name = "lblCountTickets";
            this.lblCountTickets.Size = new System.Drawing.Size(23, 28);
            this.lblCountTickets.TabIndex = 7;
            this.lblCountTickets.Text = "0";
            // 
            // CBoxCompany
            // 
            this.CBoxCompany.AutoCompleteCustomSource.AddRange(new string[] {
            "Sodexo, Up, Edenred"});
            this.CBoxCompany.FormattingEnabled = true;
            this.CBoxCompany.Items.AddRange(new object[] {
            "Sodexo",
            "Up",
            "Edenred",
            "Moje Stravenka"});
            this.CBoxCompany.Location = new System.Drawing.Point(546, 78);
            this.CBoxCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBoxCompany.Name = "CBoxCompany";
            this.CBoxCompany.Size = new System.Drawing.Size(164, 28);
            this.CBoxCompany.TabIndex = 8;
            this.CBoxCompany.SelectedIndexChanged += new System.EventHandler(this.CBoxCompany_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "EAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(546, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firma:\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(246, 558);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Přidáno poukázek:";
            // 
            // listBoxAddedTickets
            // 
            this.listBoxAddedTickets.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxAddedTickets.ItemHeight = 16;
            this.listBoxAddedTickets.Location = new System.Drawing.Point(126, 169);
            this.listBoxAddedTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxAddedTickets.Name = "listBoxAddedTickets";
            this.listBoxAddedTickets.Size = new System.Drawing.Size(879, 292);
            this.listBoxAddedTickets.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(710, 548);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 46);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Uložit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOdebratTicket
            // 
            this.btnOdebratTicket.Location = new System.Drawing.Point(357, 476);
            this.btnOdebratTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOdebratTicket.Name = "btnOdebratTicket";
            this.btnOdebratTicket.Size = new System.Drawing.Size(97, 33);
            this.btnOdebratTicket.TabIndex = 22;
            this.btnOdebratTicket.Text = "Odebrat";
            this.btnOdebratTicket.UseVisualStyleBackColor = true;
            this.btnOdebratTicket.Click += new System.EventHandler(this.btnOdebratTicket_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Odebrat označenou poukázku   -";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddTickets,
            this.menuShowInfo,
            this.menuSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1127, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddTickets
            // 
            this.menuAddTickets.Name = "menuAddTickets";
            this.menuAddTickets.Size = new System.Drawing.Size(128, 24);
            this.menuAddTickets.Text = "Přidat poukázky";
            this.menuAddTickets.Click += new System.EventHandler(this.menuAddTickets_Click);
            // 
            // menuShowInfo
            // 
            this.menuShowInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vypsatSeznamToolStripMenuItem,
            this.jenSouhrnToolStripMenuItem});
            this.menuShowInfo.Name = "menuShowInfo";
            this.menuShowInfo.Size = new System.Drawing.Size(143, 24);
            this.menuShowInfo.Text = "Souhrny poukázek";
            // 
            // vypsatSeznamToolStripMenuItem
            // 
            this.vypsatSeznamToolStripMenuItem.Name = "vypsatSeznamToolStripMenuItem";
            this.vypsatSeznamToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.vypsatSeznamToolStripMenuItem.Text = "Detailní výpis";
            this.vypsatSeznamToolStripMenuItem.Click += new System.EventHandler(this.detailniVypisToolStripMenuItem_Click);
            // 
            // jenSouhrnToolStripMenuItem
            // 
            this.jenSouhrnToolStripMenuItem.Name = "jenSouhrnToolStripMenuItem";
            this.jenSouhrnToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.jenSouhrnToolStripMenuItem.Text = "Souhrn";
            this.jenSouhrnToolStripMenuItem.Click += new System.EventHandler(this.SouhrnToolStripMenuItem_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(88, 24);
            this.menuSettings.Text = "Nastavení";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblViewInfo);
            this.panel1.Controls.Add(this.btnBackToShowAllTickets);
            this.panel1.Controls.Add(this.btnDeleteAll);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lblTotalValue);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.dateTimePickerAcceptedDay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbEAN);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnOdebratTicket);
            this.panel1.Controls.Add(this.lblCountTickets);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CBoxCompany);
            this.panel1.Controls.Add(this.listBoxAddedTickets);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 618);
            this.panel1.TabIndex = 25;
            // 
            // btnBackToShowAllTickets
            // 
            this.btnBackToShowAllTickets.BackColor = System.Drawing.Color.LightGray;
            this.btnBackToShowAllTickets.ForeColor = System.Drawing.Color.Red;
            this.btnBackToShowAllTickets.Location = new System.Drawing.Point(467, 473);
            this.btnBackToShowAllTickets.Name = "btnBackToShowAllTickets";
            this.btnBackToShowAllTickets.Size = new System.Drawing.Size(234, 36);
            this.btnBackToShowAllTickets.TabIndex = 35;
            this.btnBackToShowAllTickets.Text = "Zpět zobrazit všechny přidané";
            this.btnBackToShowAllTickets.UseVisualStyleBackColor = false;
            this.btnBackToShowAllTickets.Visible = false;
            this.btnBackToShowAllTickets.Click += new System.EventHandler(this.btnBackToShowAllTickets_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(909, 476);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(97, 33);
            this.btnDeleteAll.TabIndex = 34;
            this.btnDeleteAll.Text = "Odstranit";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Odstranit vše   -";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(845, 146);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 20);
            this.label31.TabIndex = 32;
            this.label31.Text = "Hodnota";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(733, 146);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 20);
            this.label24.TabIndex = 31;
            this.label24.Text = "Typ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(519, 146);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 20);
            this.label23.TabIndex = 30;
            this.label23.Text = "Firma";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(279, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 20);
            this.label22.TabIndex = 29;
            this.label22.Text = "EAN";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(489, 558);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 28);
            this.label21.TabIndex = 28;
            this.label21.Text = "V hodnotě:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalValue.Location = new System.Drawing.Point(595, 558);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(23, 28);
            this.lblTotalValue.TabIndex = 27;
            this.lblTotalValue.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(813, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(229, 28);
            this.label20.TabIndex = 25;
            this.label20.Text = "Datum přijetí poukázky:";
            // 
            // dateTimePickerAcceptedDay
            // 
            this.dateTimePickerAcceptedDay.Location = new System.Drawing.Point(813, 78);
            this.dateTimePickerAcceptedDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerAcceptedDay.Name = "dateTimePickerAcceptedDay";
            this.dateTimePickerAcceptedDay.Size = new System.Drawing.Size(228, 27);
            this.dateTimePickerAcceptedDay.TabIndex = 24;
            this.dateTimePickerAcceptedDay.CloseUp += new System.EventHandler(this.dateTimePickerAcceptedDay_CloseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.labTypes);
            this.panel2.Controls.Add(this.cBoxTypes);
            this.panel2.Controls.Add(this.lblVarovani);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.CBoxCompanySearch);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dateTimePickerTo);
            this.panel2.Controls.Add(this.dateTimePickerFrom);
            this.panel2.Location = new System.Drawing.Point(14, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 627);
            this.panel2.TabIndex = 26;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(936, 129);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 39);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "PDF";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labTypes
            // 
            this.labTypes.AutoSize = true;
            this.labTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labTypes.Location = new System.Drawing.Point(470, 111);
            this.labTypes.Name = "labTypes";
            this.labTypes.Size = new System.Drawing.Size(102, 28);
            this.labTypes.TabIndex = 31;
            this.labTypes.Text = "Vyber typ:";
            // 
            // cBoxTypes
            // 
            this.cBoxTypes.FormattingEnabled = true;
            this.cBoxTypes.Location = new System.Drawing.Point(470, 139);
            this.cBoxTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxTypes.Name = "cBoxTypes";
            this.cBoxTypes.Size = new System.Drawing.Size(138, 28);
            this.cBoxTypes.TabIndex = 30;
            // 
            // lblVarovani
            // 
            this.lblVarovani.AutoSize = true;
            this.lblVarovani.ForeColor = System.Drawing.Color.Red;
            this.lblVarovani.Location = new System.Drawing.Point(739, 82);
            this.lblVarovani.Name = "lblVarovani";
            this.lblVarovani.Size = new System.Drawing.Size(246, 20);
            this.lblVarovani.TabIndex = 29;
            this.lblVarovani.Text = "Detailní výpis může trvat delší dobu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbSummaryInfo);
            this.panel5.Location = new System.Drawing.Point(9, 179);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1090, 421);
            this.panel5.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 1;
            // 
            // txbSummaryInfo
            // 
            this.txbSummaryInfo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSummaryInfo.Location = new System.Drawing.Point(90, 28);
            this.txbSummaryInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSummaryInfo.Multiline = true;
            this.txbSummaryInfo.Name = "txbSummaryInfo";
            this.txbSummaryInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSummaryInfo.Size = new System.Drawing.Size(892, 368);
            this.txbSummaryInfo.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.lblTotalValueFromDB);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.lblTotalCountFromDB);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.listBoxShowSavedTickets);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Location = new System.Drawing.Point(5, 187);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1094, 409);
            this.panel4.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "EAN";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(439, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 20);
            this.label25.TabIndex = 10;
            this.label25.Text = "Firma";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(650, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 20);
            this.label26.TabIndex = 11;
            this.label26.Text = "Typ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(763, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 20);
            this.label27.TabIndex = 12;
            this.label27.Text = "Hodnota";
            // 
            // lblTotalValueFromDB
            // 
            this.lblTotalValueFromDB.AutoSize = true;
            this.lblTotalValueFromDB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalValueFromDB.Location = new System.Drawing.Point(735, 366);
            this.lblTotalValueFromDB.Name = "lblTotalValueFromDB";
            this.lblTotalValueFromDB.Size = new System.Drawing.Size(50, 28);
            this.lblTotalValueFromDB.TabIndex = 18;
            this.lblTotalValueFromDB.Text = "0 Kč";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(923, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(97, 20);
            this.label28.TabIndex = 13;
            this.label28.Text = "Datum přijetí";
            // 
            // lblTotalCountFromDB
            // 
            this.lblTotalCountFromDB.AutoSize = true;
            this.lblTotalCountFromDB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalCountFromDB.Location = new System.Drawing.Point(415, 366);
            this.lblTotalCountFromDB.Name = "lblTotalCountFromDB";
            this.lblTotalCountFromDB.Size = new System.Drawing.Size(23, 28);
            this.lblTotalCountFromDB.TabIndex = 16;
            this.lblTotalCountFromDB.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(573, 366);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(165, 28);
            this.label29.TabIndex = 17;
            this.label29.Text = "Celkem hodnota:";
            // 
            // listBoxShowSavedTickets
            // 
            this.listBoxShowSavedTickets.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxShowSavedTickets.FormattingEnabled = true;
            this.listBoxShowSavedTickets.ItemHeight = 16;
            this.listBoxShowSavedTickets.Location = new System.Drawing.Point(43, 40);
            this.listBoxShowSavedTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxShowSavedTickets.Name = "listBoxShowSavedTickets";
            this.listBoxShowSavedTickets.Size = new System.Drawing.Size(1006, 308);
            this.listBoxShowSavedTickets.TabIndex = 8;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(288, 366);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(133, 28);
            this.label30.TabIndex = 15;
            this.label30.Text = "Celkem kusů:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(798, 129);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 39);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Vyhledat";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(197, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 28);
            this.label16.TabIndex = 6;
            this.label16.Text = "Vyber datum:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(197, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 28);
            this.label15.TabIndex = 5;
            this.label15.Text = "Vyber firmu:";
            // 
            // CBoxCompanySearch
            // 
            this.CBoxCompanySearch.DisplayMember = "0";
            this.CBoxCompanySearch.FormattingEnabled = true;
            this.CBoxCompanySearch.Location = new System.Drawing.Point(197, 139);
            this.CBoxCompanySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBoxCompanySearch.Name = "CBoxCompanySearch";
            this.CBoxCompanySearch.Size = new System.Drawing.Size(138, 28);
            this.CBoxCompanySearch.TabIndex = 4;
            this.CBoxCompanySearch.Tag = "";
            this.CBoxCompanySearch.SelectedIndexChanged += new System.EventHandler(this.CBoxCompanySearch_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(432, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "do:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(159, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "od:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(470, 75);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(228, 27);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(197, 75);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(228, 27);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnCreateDB);
            this.panel3.Controls.Add(this.txbPath);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.btnSetPath);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(7, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1110, 604);
            this.panel3.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Developed by Afareus89@gmail.com";
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(504, 411);
            this.btnCreateDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(80, 31);
            this.btnCreateDB.TabIndex = 6;
            this.btnCreateDB.Text = "Vytvořit";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(353, 174);
            this.txbPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(396, 27);
            this.txbPath.TabIndex = 5;
            this.txbPath.Text = "C:\\Users\\Public\\Documents\\databaze.dat";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(458, 147);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Cesta k aktuální databázi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(458, 375);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "Vytvořit Novou Databázi:";
            // 
            // btnSetPath
            // 
            this.btnSetPath.Location = new System.Drawing.Point(504, 215);
            this.btnSetPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(80, 31);
            this.btnSetPath.TabIndex = 2;
            this.btnSetPath.Text = "Upravit";
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(419, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(280, 28);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nastavení přístupu k databázi";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblViewInfo
            // 
            this.lblViewInfo.AutoSize = true;
            this.lblViewInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblViewInfo.ForeColor = System.Drawing.Color.Red;
            this.lblViewInfo.Location = new System.Drawing.Point(126, 479);
            this.lblViewInfo.Name = "lblViewInfo";
            this.lblViewInfo.Size = new System.Drawing.Size(96, 23);
            this.lblViewInfo.TabIndex = 36;
            this.lblViewInfo.Text = "lblViewInfo";
            this.lblViewInfo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1127, 665);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1145, 712);
            this.MinimumSize = new System.Drawing.Size(1145, 712);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oxana - Sken poukázek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEAN;
        private System.Windows.Forms.Label lblCountTickets;
        private System.Windows.Forms.ComboBox CBoxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxAddedTickets;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOdebratTicket;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddTickets;
        private System.Windows.Forms.ToolStripMenuItem menuShowInfo;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBoxCompanySearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBoxShowSavedTickets;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePickerAcceptedDay;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblTotalCountFromDB;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblTotalValueFromDB;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ToolStripMenuItem vypsatSeznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jenSouhrnToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbSummaryInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVarovani;
        private System.Windows.Forms.Label labTypes;
        private System.Windows.Forms.ComboBox cBoxTypes;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackToShowAllTickets;
        private System.Windows.Forms.Label lblViewInfo;
    }
}

