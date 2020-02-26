namespace WebApiKlient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.produktyZakladka = new System.Windows.Forms.TabPage();
            this.usunProduktPrzycisk = new System.Windows.Forms.Button();
            this.dodajNowyProduktPrzycisk = new System.Windows.Forms.Button();
            this.modyfikujPrzycisk = new System.Windows.Forms.Button();
            this.poleCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.poleNazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.poleId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pobierzProduktyPrzycisk = new System.Windows.Forms.Button();
            this.produktyListBox = new System.Windows.Forms.ListBox();
            this.klienciZakladka = new System.Windows.Forms.TabPage();
            this.usunKlienciPrzycisk = new System.Windows.Forms.Button();
            this.dodajNowyPrzyciskKlienci = new System.Windows.Forms.Button();
            this.modyfikujKlienciPrzycisk = new System.Windows.Forms.Button();
            this.poleNazwisko = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.poleImie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.poleIdKlienci = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pobierzInformacjeOKlientachPrzycisk = new System.Windows.Forms.Button();
            this.klienciListBox = new System.Windows.Forms.ListBox();
            this.zamowieniaZakladka = new System.Windows.Forms.TabPage();
            this.poleKlient = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.poleProdukt = new System.Windows.Forms.ComboBox();
            this.usunZamowieniaPrzycisk = new System.Windows.Forms.Button();
            this.zlozZamowieniePrzycisk = new System.Windows.Forms.Button();
            this.modyfikujZamowieniaPrzycisk = new System.Windows.Forms.Button();
            this.poleLiczbaSztuk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.poleIdZamowienia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pobierzInformacjeOZamowieniachPrzycisk = new System.Windows.Forms.Button();
            this.zamowieniaListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.produktyZakladka.SuspendLayout();
            this.klienciZakladka.SuspendLayout();
            this.zamowieniaZakladka.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.produktyZakladka);
            this.tabControl1.Controls.Add(this.klienciZakladka);
            this.tabControl1.Controls.Add(this.zamowieniaZakladka);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // produktyZakladka
            // 
            this.produktyZakladka.Controls.Add(this.usunProduktPrzycisk);
            this.produktyZakladka.Controls.Add(this.dodajNowyProduktPrzycisk);
            this.produktyZakladka.Controls.Add(this.modyfikujPrzycisk);
            this.produktyZakladka.Controls.Add(this.poleCena);
            this.produktyZakladka.Controls.Add(this.label3);
            this.produktyZakladka.Controls.Add(this.poleNazwa);
            this.produktyZakladka.Controls.Add(this.label2);
            this.produktyZakladka.Controls.Add(this.poleId);
            this.produktyZakladka.Controls.Add(this.label1);
            this.produktyZakladka.Controls.Add(this.pobierzProduktyPrzycisk);
            this.produktyZakladka.Controls.Add(this.produktyListBox);
            this.produktyZakladka.Location = new System.Drawing.Point(4, 22);
            this.produktyZakladka.Name = "produktyZakladka";
            this.produktyZakladka.Padding = new System.Windows.Forms.Padding(3);
            this.produktyZakladka.Size = new System.Drawing.Size(418, 305);
            this.produktyZakladka.TabIndex = 0;
            this.produktyZakladka.Text = "Produkty";
            this.produktyZakladka.UseVisualStyleBackColor = true;
            // 
            // usunProduktPrzycisk
            // 
            this.usunProduktPrzycisk.Location = new System.Drawing.Point(234, 221);
            this.usunProduktPrzycisk.Name = "usunProduktPrzycisk";
            this.usunProduktPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.usunProduktPrzycisk.TabIndex = 10;
            this.usunProduktPrzycisk.Text = "Usuń";
            this.usunProduktPrzycisk.UseVisualStyleBackColor = true;
            this.usunProduktPrzycisk.Click += new System.EventHandler(this.usunProduktPrzycisk_Click);
            // 
            // dodajNowyProduktPrzycisk
            // 
            this.dodajNowyProduktPrzycisk.Location = new System.Drawing.Point(234, 191);
            this.dodajNowyProduktPrzycisk.Name = "dodajNowyProduktPrzycisk";
            this.dodajNowyProduktPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.dodajNowyProduktPrzycisk.TabIndex = 9;
            this.dodajNowyProduktPrzycisk.Text = "Dodaj nowy";
            this.dodajNowyProduktPrzycisk.UseVisualStyleBackColor = true;
            this.dodajNowyProduktPrzycisk.Click += new System.EventHandler(this.dodajNowyProduktPrzycisk_Click);
            // 
            // modyfikujPrzycisk
            // 
            this.modyfikujPrzycisk.Location = new System.Drawing.Point(234, 161);
            this.modyfikujPrzycisk.Name = "modyfikujPrzycisk";
            this.modyfikujPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.modyfikujPrzycisk.TabIndex = 8;
            this.modyfikujPrzycisk.Text = "Modyfikuj";
            this.modyfikujPrzycisk.UseVisualStyleBackColor = true;
            this.modyfikujPrzycisk.Click += new System.EventHandler(this.modyfikujPrzycisk_Click);
            // 
            // poleCena
            // 
            this.poleCena.Location = new System.Drawing.Point(234, 134);
            this.poleCena.Name = "poleCena";
            this.poleCena.Size = new System.Drawing.Size(178, 20);
            this.poleCena.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena";
            // 
            // poleNazwa
            // 
            this.poleNazwa.Location = new System.Drawing.Point(234, 94);
            this.poleNazwa.Name = "poleNazwa";
            this.poleNazwa.Size = new System.Drawing.Size(178, 20);
            this.poleNazwa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa";
            // 
            // poleId
            // 
            this.poleId.Enabled = false;
            this.poleId.Location = new System.Drawing.Point(234, 54);
            this.poleId.Name = "poleId";
            this.poleId.Size = new System.Drawing.Size(178, 20);
            this.poleId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // pobierzProduktyPrzycisk
            // 
            this.pobierzProduktyPrzycisk.Location = new System.Drawing.Point(234, 7);
            this.pobierzProduktyPrzycisk.Name = "pobierzProduktyPrzycisk";
            this.pobierzProduktyPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.pobierzProduktyPrzycisk.TabIndex = 1;
            this.pobierzProduktyPrzycisk.Text = "Pobierz produkty";
            this.pobierzProduktyPrzycisk.UseVisualStyleBackColor = true;
            this.pobierzProduktyPrzycisk.Click += new System.EventHandler(this.pobierzProduktyPrzycisk_Click);
            // 
            // produktyListBox
            // 
            this.produktyListBox.FormattingEnabled = true;
            this.produktyListBox.Location = new System.Drawing.Point(6, 6);
            this.produktyListBox.Name = "produktyListBox";
            this.produktyListBox.Size = new System.Drawing.Size(221, 264);
            this.produktyListBox.TabIndex = 0;
            this.produktyListBox.SelectedIndexChanged += new System.EventHandler(this.produktyListBox_SelectedIndexChanged);
            // 
            // klienciZakladka
            // 
            this.klienciZakladka.Controls.Add(this.usunKlienciPrzycisk);
            this.klienciZakladka.Controls.Add(this.dodajNowyPrzyciskKlienci);
            this.klienciZakladka.Controls.Add(this.modyfikujKlienciPrzycisk);
            this.klienciZakladka.Controls.Add(this.poleNazwisko);
            this.klienciZakladka.Controls.Add(this.label4);
            this.klienciZakladka.Controls.Add(this.poleImie);
            this.klienciZakladka.Controls.Add(this.label5);
            this.klienciZakladka.Controls.Add(this.poleIdKlienci);
            this.klienciZakladka.Controls.Add(this.label6);
            this.klienciZakladka.Controls.Add(this.pobierzInformacjeOKlientachPrzycisk);
            this.klienciZakladka.Controls.Add(this.klienciListBox);
            this.klienciZakladka.Location = new System.Drawing.Point(4, 22);
            this.klienciZakladka.Name = "klienciZakladka";
            this.klienciZakladka.Padding = new System.Windows.Forms.Padding(3);
            this.klienciZakladka.Size = new System.Drawing.Size(418, 305);
            this.klienciZakladka.TabIndex = 1;
            this.klienciZakladka.Text = "Klienci";
            this.klienciZakladka.UseVisualStyleBackColor = true;
            // 
            // usunKlienciPrzycisk
            // 
            this.usunKlienciPrzycisk.Location = new System.Drawing.Point(234, 221);
            this.usunKlienciPrzycisk.Name = "usunKlienciPrzycisk";
            this.usunKlienciPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.usunKlienciPrzycisk.TabIndex = 21;
            this.usunKlienciPrzycisk.Text = "Usuń";
            this.usunKlienciPrzycisk.UseVisualStyleBackColor = true;
            this.usunKlienciPrzycisk.Click += new System.EventHandler(this.usunKlienciPrzycisk_Click);
            // 
            // dodajNowyPrzyciskKlienci
            // 
            this.dodajNowyPrzyciskKlienci.Location = new System.Drawing.Point(234, 191);
            this.dodajNowyPrzyciskKlienci.Name = "dodajNowyPrzyciskKlienci";
            this.dodajNowyPrzyciskKlienci.Size = new System.Drawing.Size(178, 23);
            this.dodajNowyPrzyciskKlienci.TabIndex = 20;
            this.dodajNowyPrzyciskKlienci.Text = "Dodaj nowy";
            this.dodajNowyPrzyciskKlienci.UseVisualStyleBackColor = true;
            this.dodajNowyPrzyciskKlienci.Click += new System.EventHandler(this.dodajNowyPrzyciskKlienci_Click);
            // 
            // modyfikujKlienciPrzycisk
            // 
            this.modyfikujKlienciPrzycisk.Location = new System.Drawing.Point(234, 161);
            this.modyfikujKlienciPrzycisk.Name = "modyfikujKlienciPrzycisk";
            this.modyfikujKlienciPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.modyfikujKlienciPrzycisk.TabIndex = 19;
            this.modyfikujKlienciPrzycisk.Text = "Modyfikuj";
            this.modyfikujKlienciPrzycisk.UseVisualStyleBackColor = true;
            this.modyfikujKlienciPrzycisk.Click += new System.EventHandler(this.modyfikujKlienciPrzycisk_Click);
            // 
            // poleNazwisko
            // 
            this.poleNazwisko.Location = new System.Drawing.Point(234, 134);
            this.poleNazwisko.Name = "poleNazwisko";
            this.poleNazwisko.Size = new System.Drawing.Size(178, 20);
            this.poleNazwisko.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nazwisko";
            // 
            // poleImie
            // 
            this.poleImie.Location = new System.Drawing.Point(234, 94);
            this.poleImie.Name = "poleImie";
            this.poleImie.Size = new System.Drawing.Size(178, 20);
            this.poleImie.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Imię";
            // 
            // poleIdKlienci
            // 
            this.poleIdKlienci.Enabled = false;
            this.poleIdKlienci.Location = new System.Drawing.Point(234, 54);
            this.poleIdKlienci.Name = "poleIdKlienci";
            this.poleIdKlienci.Size = new System.Drawing.Size(178, 20);
            this.poleIdKlienci.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // pobierzInformacjeOKlientachPrzycisk
            // 
            this.pobierzInformacjeOKlientachPrzycisk.Location = new System.Drawing.Point(234, 7);
            this.pobierzInformacjeOKlientachPrzycisk.Name = "pobierzInformacjeOKlientachPrzycisk";
            this.pobierzInformacjeOKlientachPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.pobierzInformacjeOKlientachPrzycisk.TabIndex = 12;
            this.pobierzInformacjeOKlientachPrzycisk.Text = "Pobierz informacje o klientach";
            this.pobierzInformacjeOKlientachPrzycisk.UseVisualStyleBackColor = true;
            this.pobierzInformacjeOKlientachPrzycisk.Click += new System.EventHandler(this.pobierzInformacjeOKlientachPrzycisk_Click);
            // 
            // klienciListBox
            // 
            this.klienciListBox.FormattingEnabled = true;
            this.klienciListBox.Location = new System.Drawing.Point(6, 6);
            this.klienciListBox.Name = "klienciListBox";
            this.klienciListBox.Size = new System.Drawing.Size(221, 264);
            this.klienciListBox.TabIndex = 11;
            this.klienciListBox.SelectedIndexChanged += new System.EventHandler(this.klienciListBox_SelectedIndexChanged);
            // 
            // zamowieniaZakladka
            // 
            this.zamowieniaZakladka.Controls.Add(this.poleKlient);
            this.zamowieniaZakladka.Controls.Add(this.label10);
            this.zamowieniaZakladka.Controls.Add(this.poleProdukt);
            this.zamowieniaZakladka.Controls.Add(this.usunZamowieniaPrzycisk);
            this.zamowieniaZakladka.Controls.Add(this.zlozZamowieniePrzycisk);
            this.zamowieniaZakladka.Controls.Add(this.modyfikujZamowieniaPrzycisk);
            this.zamowieniaZakladka.Controls.Add(this.poleLiczbaSztuk);
            this.zamowieniaZakladka.Controls.Add(this.label7);
            this.zamowieniaZakladka.Controls.Add(this.label8);
            this.zamowieniaZakladka.Controls.Add(this.poleIdZamowienia);
            this.zamowieniaZakladka.Controls.Add(this.label9);
            this.zamowieniaZakladka.Controls.Add(this.pobierzInformacjeOZamowieniachPrzycisk);
            this.zamowieniaZakladka.Controls.Add(this.zamowieniaListBox);
            this.zamowieniaZakladka.Location = new System.Drawing.Point(4, 22);
            this.zamowieniaZakladka.Name = "zamowieniaZakladka";
            this.zamowieniaZakladka.Size = new System.Drawing.Size(418, 305);
            this.zamowieniaZakladka.TabIndex = 2;
            this.zamowieniaZakladka.Text = "Zamówienia";
            this.zamowieniaZakladka.UseVisualStyleBackColor = true;
            // 
            // poleKlient
            // 
            this.poleKlient.FormattingEnabled = true;
            this.poleKlient.Location = new System.Drawing.Point(231, 181);
            this.poleKlient.Name = "poleKlient";
            this.poleKlient.Size = new System.Drawing.Size(178, 21);
            this.poleKlient.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Klient";
            // 
            // poleProdukt
            // 
            this.poleProdukt.FormattingEnabled = true;
            this.poleProdukt.Location = new System.Drawing.Point(231, 101);
            this.poleProdukt.Name = "poleProdukt";
            this.poleProdukt.Size = new System.Drawing.Size(178, 21);
            this.poleProdukt.TabIndex = 33;
            // 
            // usunZamowieniaPrzycisk
            // 
            this.usunZamowieniaPrzycisk.Location = new System.Drawing.Point(231, 268);
            this.usunZamowieniaPrzycisk.Name = "usunZamowieniaPrzycisk";
            this.usunZamowieniaPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.usunZamowieniaPrzycisk.TabIndex = 32;
            this.usunZamowieniaPrzycisk.Text = "Usuń";
            this.usunZamowieniaPrzycisk.UseVisualStyleBackColor = true;
            this.usunZamowieniaPrzycisk.Click += new System.EventHandler(this.usunZamowieniaPrzycisk_Click);
            // 
            // zlozZamowieniePrzycisk
            // 
            this.zlozZamowieniePrzycisk.Location = new System.Drawing.Point(231, 238);
            this.zlozZamowieniePrzycisk.Name = "zlozZamowieniePrzycisk";
            this.zlozZamowieniePrzycisk.Size = new System.Drawing.Size(178, 23);
            this.zlozZamowieniePrzycisk.TabIndex = 31;
            this.zlozZamowieniePrzycisk.Text = "Złóż zamówienie";
            this.zlozZamowieniePrzycisk.UseVisualStyleBackColor = true;
            this.zlozZamowieniePrzycisk.Click += new System.EventHandler(this.zlozZamowieniePrzycisk_Click);
            // 
            // modyfikujZamowieniaPrzycisk
            // 
            this.modyfikujZamowieniaPrzycisk.Location = new System.Drawing.Point(231, 208);
            this.modyfikujZamowieniaPrzycisk.Name = "modyfikujZamowieniaPrzycisk";
            this.modyfikujZamowieniaPrzycisk.Size = new System.Drawing.Size(178, 23);
            this.modyfikujZamowieniaPrzycisk.TabIndex = 30;
            this.modyfikujZamowieniaPrzycisk.Text = "Modyfikuj";
            this.modyfikujZamowieniaPrzycisk.UseVisualStyleBackColor = true;
            this.modyfikujZamowieniaPrzycisk.Click += new System.EventHandler(this.modyfikujZamowieniaPrzycisk_Click);
            // 
            // poleLiczbaSztuk
            // 
            this.poleLiczbaSztuk.Location = new System.Drawing.Point(231, 141);
            this.poleLiczbaSztuk.Name = "poleLiczbaSztuk";
            this.poleLiczbaSztuk.Size = new System.Drawing.Size(178, 20);
            this.poleLiczbaSztuk.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Liczba sztuk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Produkt";
            // 
            // poleIdZamowienia
            // 
            this.poleIdZamowienia.Enabled = false;
            this.poleIdZamowienia.Location = new System.Drawing.Point(231, 61);
            this.poleIdZamowienia.Name = "poleIdZamowienia";
            this.poleIdZamowienia.Size = new System.Drawing.Size(178, 20);
            this.poleIdZamowienia.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID";
            // 
            // pobierzInformacjeOZamowieniachPrzycisk
            // 
            this.pobierzInformacjeOZamowieniachPrzycisk.Location = new System.Drawing.Point(231, 4);
            this.pobierzInformacjeOZamowieniachPrzycisk.Name = "pobierzInformacjeOZamowieniachPrzycisk";
            this.pobierzInformacjeOZamowieniachPrzycisk.Size = new System.Drawing.Size(178, 39);
            this.pobierzInformacjeOZamowieniachPrzycisk.TabIndex = 23;
            this.pobierzInformacjeOZamowieniachPrzycisk.Text = "Pobierz informacje o zamówieniach";
            this.pobierzInformacjeOZamowieniachPrzycisk.UseVisualStyleBackColor = true;
            this.pobierzInformacjeOZamowieniachPrzycisk.Click += new System.EventHandler(this.pobierzInformacjeOZamowieniachPrzycisk_Click);
            // 
            // zamowieniaListBox
            // 
            this.zamowieniaListBox.FormattingEnabled = true;
            this.zamowieniaListBox.Location = new System.Drawing.Point(3, 3);
            this.zamowieniaListBox.Name = "zamowieniaListBox";
            this.zamowieniaListBox.Size = new System.Drawing.Size(221, 264);
            this.zamowieniaListBox.TabIndex = 22;
            this.zamowieniaListBox.SelectedIndexChanged += new System.EventHandler(this.zamowieniaListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 364);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.produktyZakladka.ResumeLayout(false);
            this.produktyZakladka.PerformLayout();
            this.klienciZakladka.ResumeLayout(false);
            this.klienciZakladka.PerformLayout();
            this.zamowieniaZakladka.ResumeLayout(false);
            this.zamowieniaZakladka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage produktyZakladka;
        private System.Windows.Forms.Button usunProduktPrzycisk;
        private System.Windows.Forms.Button dodajNowyProduktPrzycisk;
        private System.Windows.Forms.Button modyfikujPrzycisk;
        private System.Windows.Forms.TextBox poleCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poleNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poleId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pobierzProduktyPrzycisk;
        private System.Windows.Forms.ListBox produktyListBox;
        private System.Windows.Forms.TabPage klienciZakladka;
        private System.Windows.Forms.TabPage zamowieniaZakladka;
        private System.Windows.Forms.Button usunKlienciPrzycisk;
        private System.Windows.Forms.Button dodajNowyPrzyciskKlienci;
        private System.Windows.Forms.Button modyfikujKlienciPrzycisk;
        private System.Windows.Forms.TextBox poleNazwisko;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox poleImie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox poleIdKlienci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pobierzInformacjeOKlientachPrzycisk;
        private System.Windows.Forms.ListBox klienciListBox;
        private System.Windows.Forms.Button usunZamowieniaPrzycisk;
        private System.Windows.Forms.Button zlozZamowieniePrzycisk;
        private System.Windows.Forms.Button modyfikujZamowieniaPrzycisk;
        private System.Windows.Forms.TextBox poleLiczbaSztuk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox poleIdZamowienia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button pobierzInformacjeOZamowieniachPrzycisk;
        private System.Windows.Forms.ListBox zamowieniaListBox;
        private System.Windows.Forms.ComboBox poleKlient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox poleProdukt;
    }
}

