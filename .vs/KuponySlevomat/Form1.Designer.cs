
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
            this.lblEAN = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblValidity = new System.Windows.Forms.Label();
            this.lblAdded = new System.Windows.Forms.Label();
            this.lblCountTickets = new System.Windows.Forms.Label();
            this.CBoxCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxAddedTickets = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOdebratTicket = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAddTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePickerAcceptedDay = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalValueFromDB = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblTotalCountFromDB = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxShowSavedTickets = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CBoxCompanySearch = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbEAN
            // 
            this.txbEAN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbEAN.Location = new System.Drawing.Point(47, 61);
            this.txbEAN.Multiline = true;
            this.txbEAN.Name = "txbEAN";
            this.txbEAN.Size = new System.Drawing.Size(314, 31);
            this.txbEAN.TabIndex = 0;
            this.txbEAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEAN_Enter);
            // 
            // lblEAN
            // 
            this.lblEAN.AutoSize = true;
            this.lblEAN.Location = new System.Drawing.Point(150, 319);
            this.lblEAN.Name = "lblEAN";
            this.lblEAN.Size = new System.Drawing.Size(13, 17);
            this.lblEAN.TabIndex = 1;
            this.lblEAN.Text = "-";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(150, 336);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(13, 17);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "-";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(150, 353);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(13, 17);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "-";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(150, 370);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(13, 17);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "-";
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.Location = new System.Drawing.Point(150, 387);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(13, 17);
            this.lblValidity.TabIndex = 5;
            this.lblValidity.Text = "-";
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.Location = new System.Drawing.Point(150, 404);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(13, 17);
            this.lblAdded.TabIndex = 6;
            this.lblAdded.Text = "-";
            // 
            // lblCountTickets
            // 
            this.lblCountTickets.AutoSize = true;
            this.lblCountTickets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCountTickets.Location = new System.Drawing.Point(364, 448);
            this.lblCountTickets.Name = "lblCountTickets";
            this.lblCountTickets.Size = new System.Drawing.Size(19, 21);
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
            this.CBoxCompany.Location = new System.Drawing.Point(47, 138);
            this.CBoxCompany.Name = "CBoxCompany";
            this.CBoxCompany.Size = new System.Drawing.Size(144, 25);
            this.CBoxCompany.TabIndex = 8;
            this.CBoxCompany.SelectedIndexChanged += new System.EventHandler(this.CBoxCompany_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "EAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firma:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "EAN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Poslední přidaná poukázka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Firma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Typ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hodnota:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Platnost do:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Přijato:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(212, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Přidáno poukázek:";
            // 
            // listBoxAddedTickets
            // 
            this.listBoxAddedTickets.ItemHeight = 17;
            this.listBoxAddedTickets.Location = new System.Drawing.Point(417, 61);
            this.listBoxAddedTickets.Name = "listBoxAddedTickets";
            this.listBoxAddedTickets.Size = new System.Drawing.Size(519, 310);
            this.listBoxAddedTickets.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 31);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Uložit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOdebratTicket
            // 
            this.btnOdebratTicket.Location = new System.Drawing.Point(714, 387);
            this.btnOdebratTicket.Name = "btnOdebratTicket";
            this.btnOdebratTicket.Size = new System.Drawing.Size(85, 28);
            this.btnOdebratTicket.TabIndex = 22;
            this.btnOdebratTicket.Text = "Odebrat";
            this.btnOdebratTicket.UseVisualStyleBackColor = true;
            this.btnOdebratTicket.Click += new System.EventHandler(this.btnOdebratTicket_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Odebrat označenou poukázku   -";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddTickets,
            this.menuShowInfo,
            this.menuSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 25);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddTickets
            // 
            this.menuAddTickets.Name = "menuAddTickets";
            this.menuAddTickets.Size = new System.Drawing.Size(112, 21);
            this.menuAddTickets.Text = "Přidat poukázky";
            this.menuAddTickets.Click += new System.EventHandler(this.menuAddTickets_Click);
            // 
            // menuShowInfo
            // 
            this.menuShowInfo.Name = "menuShowInfo";
            this.menuShowInfo.Size = new System.Drawing.Size(126, 21);
            this.menuShowInfo.Text = "Souhrny poukázek";
            this.menuShowInfo.Click += new System.EventHandler(this.menuShowInfo_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(77, 21);
            this.menuSettings.Text = "Nastavení";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // panel1
            // 
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
            this.panel1.Controls.Add(this.lblAdded);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblValidity);
            this.panel1.Controls.Add(this.btnOdebratTicket);
            this.panel1.Controls.Add(this.lblValue);
            this.panel1.Controls.Add(this.lblCountTickets);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblEAN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CBoxCompany);
            this.panel1.Controls.Add(this.listBoxAddedTickets);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 525);
            this.panel1.TabIndex = 25;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(877, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 17);
            this.label31.TabIndex = 32;
            this.label31.Text = "Hodnota";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(794, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 17);
            this.label24.TabIndex = 31;
            this.label24.Text = "Typ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(697, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 17);
            this.label23.TabIndex = 30;
            this.label23.Text = "Firma";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(530, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 17);
            this.label22.TabIndex = 29;
            this.label22.Text = "EAN";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(424, 448);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 21);
            this.label21.TabIndex = 28;
            this.label21.Text = "V hodnotě:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalValue.Location = new System.Drawing.Point(524, 448);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(19, 21);
            this.lblTotalValue.TabIndex = 27;
            this.lblTotalValue.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(47, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 21);
            this.label20.TabIndex = 25;
            this.label20.Text = "Datum přijetí poukázky:";
            // 
            // dateTimePickerAcceptedDay
            // 
            this.dateTimePickerAcceptedDay.Location = new System.Drawing.Point(47, 212);
            this.dateTimePickerAcceptedDay.Name = "dateTimePickerAcceptedDay";
            this.dateTimePickerAcceptedDay.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerAcceptedDay.TabIndex = 24;
            this.dateTimePickerAcceptedDay.ValueChanged += new System.EventHandler(this.dateTimePickerAcceptedDay_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalValueFromDB);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.lblTotalCountFromDB);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.listBoxShowSavedTickets);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.CBoxCompanySearch);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dateTimePickerTo);
            this.panel2.Controls.Add(this.dateTimePickerFrom);
            this.panel2.Location = new System.Drawing.Point(6, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 502);
            this.panel2.TabIndex = 26;
            // 
            // lblTotalValueFromDB
            // 
            this.lblTotalValueFromDB.AutoSize = true;
            this.lblTotalValueFromDB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalValueFromDB.Location = new System.Drawing.Point(855, 332);
            this.lblTotalValueFromDB.Name = "lblTotalValueFromDB";
            this.lblTotalValueFromDB.Size = new System.Drawing.Size(40, 21);
            this.lblTotalValueFromDB.TabIndex = 18;
            this.lblTotalValueFromDB.Text = "0 Kč";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(718, 332);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(131, 21);
            this.label29.TabIndex = 17;
            this.label29.Text = "Celkem hodnota:";
            // 
            // lblTotalCountFromDB
            // 
            this.lblTotalCountFromDB.AutoSize = true;
            this.lblTotalCountFromDB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalCountFromDB.Location = new System.Drawing.Point(830, 245);
            this.lblTotalCountFromDB.Name = "lblTotalCountFromDB";
            this.lblTotalCountFromDB.Size = new System.Drawing.Size(19, 21);
            this.lblTotalCountFromDB.TabIndex = 16;
            this.lblTotalCountFromDB.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(720, 245);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 21);
            this.label30.TabIndex = 15;
            this.label30.Text = "Celkem kusů:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(592, 153);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 17);
            this.label28.TabIndex = 13;
            this.label28.Text = "Datum přijetí";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(498, 153);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 17);
            this.label27.TabIndex = 12;
            this.label27.Text = "Hodnota";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(424, 153);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 17);
            this.label26.TabIndex = 11;
            this.label26.Text = "Typ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(321, 153);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 17);
            this.label25.TabIndex = 10;
            this.label25.Text = "Firma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "EAN";
            // 
            // listBoxShowSavedTickets
            // 
            this.listBoxShowSavedTickets.FormattingEnabled = true;
            this.listBoxShowSavedTickets.ItemHeight = 17;
            this.listBoxShowSavedTickets.Location = new System.Drawing.Point(31, 176);
            this.listBoxShowSavedTickets.Name = "listBoxShowSavedTickets";
            this.listBoxShowSavedTickets.Size = new System.Drawing.Size(658, 259);
            this.listBoxShowSavedTickets.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(334, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 33);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Vyhledat";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(31, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 21);
            this.label16.TabIndex = 6;
            this.label16.Text = "Vyber datum:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(31, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 21);
            this.label15.TabIndex = 5;
            this.label15.Text = "Vyber firmu:";
            // 
            // CBoxCompanySearch
            // 
            this.CBoxCompanySearch.DisplayMember = "0";
            this.CBoxCompanySearch.FormattingEnabled = true;
            this.CBoxCompanySearch.Location = new System.Drawing.Point(31, 119);
            this.CBoxCompanySearch.Name = "CBoxCompanySearch";
            this.CBoxCompanySearch.Size = new System.Drawing.Size(132, 25);
            this.CBoxCompanySearch.TabIndex = 4;
            this.CBoxCompanySearch.Tag = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "do:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Od:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(334, 64);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(195, 25);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(66, 64);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreateDB);
            this.panel3.Controls.Add(this.txbPath);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.btnSetPath);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(16, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 489);
            this.panel3.TabIndex = 27;
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(441, 349);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(70, 26);
            this.btnCreateDB.TabIndex = 6;
            this.btnCreateDB.Text = "Vytvořit";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(309, 148);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(347, 25);
            this.txbPath.TabIndex = 5;
            this.txbPath.Text = "C:\\Users\\Public\\Documents\\databaze.dat";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(401, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Cesta k aktuální databázi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(401, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Vytvořit Novou Databázi:";
            // 
            // btnSetPath
            // 
            this.btnSetPath.Location = new System.Drawing.Point(441, 183);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(70, 26);
            this.btnSetPath.TabIndex = 2;
            this.btnSetPath.Text = "Upravit";
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(367, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(227, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nastavení přístupu k databázi";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(988, 573);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1004, 612);
            this.MinimumSize = new System.Drawing.Size(1004, 612);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KuponySken";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEAN;
        private System.Windows.Forms.Label lblEAN;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.Label lblAdded;
        private System.Windows.Forms.Label lblCountTickets;
        private System.Windows.Forms.ComboBox CBoxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
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
    }
}

