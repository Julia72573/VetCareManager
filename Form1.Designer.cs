namespace VetCare_Manager
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            dgvNajblizszeWizyty = new DataGridView();
            dataGridView2 = new DataGridView();
            txtImie = new TextBox();
            txtRasa = new TextBox();
            cmbGatunek = new ComboBox();
            txtOwnerId = new TextBox();
            dtpDataUrodzenia = new DateTimePicker();
            btnDodaj = new Button();
            txtSzukajImie = new TextBox();
            txtSzukajTelefon = new TextBox();
            cmbLekarz = new ComboBox();
            dtpDataWizyty = new DateTimePicker();
            txtCelWizyty = new TextBox();
            btnUmowWizyte = new Button();
            txtSzukajWlascicielaImie = new TextBox();
            txtSzukajWlascicielaNazwisko = new TextBox();
            txtSzukajWlascicielaTelefon = new TextBox();
            txtNowyWlascicielImie = new TextBox();
            txtNowyWlascicielNazwisko = new TextBox();
            txtNowyWlascicielTelefon = new TextBox();
            btnDodajWlasciciela = new Button();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label35 = new Label();
            pbLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            btnUsunPacjenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNajblizszeWizyty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(989, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(648, 428);
            dataGridView1.TabIndex = 0;
            // 
            // dgvNajblizszeWizyty
            // 
            dgvNajblizszeWizyty.Location = new Point(989, 483);
            dgvNajblizszeWizyty.Name = "dgvNajblizszeWizyty";
            dgvNajblizszeWizyty.Size = new Size(648, 310);
            dgvNajblizszeWizyty.TabIndex = 13;
            // 
            // dataGridView2
            // 
            dataGridView2.Location = new Point(989, 842);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(648, 98);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(12, 73);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(100, 23);
            txtImie.TabIndex = 25;
            // 
            // txtRasa
            // 
            txtRasa.Location = new Point(122, 72);
            txtRasa.Name = "txtRasa";
            txtRasa.Size = new Size(100, 23);
            txtRasa.TabIndex = 26;
            // 
            // cmbGatunek
            // 
            cmbGatunek.Items.AddRange(new object[] { "Pies", "Kot" });
            cmbGatunek.Location = new Point(232, 72);
            cmbGatunek.Name = "cmbGatunek";
            cmbGatunek.Size = new Size(121, 23);
            cmbGatunek.TabIndex = 27;
            // 
            // txtOwnerId
            // 
            txtOwnerId.Location = new Point(571, 72);
            txtOwnerId.Name = "txtOwnerId";
            txtOwnerId.Size = new Size(100, 23);
            txtOwnerId.TabIndex = 28;
            // 
            // dtpDataUrodzenia
            // 
            dtpDataUrodzenia.Location = new Point(365, 72);
            dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            dtpDataUrodzenia.Size = new Size(200, 23);
            dtpDataUrodzenia.TabIndex = 29;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(686, 72);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 30;
            btnDodaj.Text = "Zarejestruj";
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txtSzukajImie
            // 
            txtSzukajImie.Location = new Point(12, 254);
            txtSzukajImie.Name = "txtSzukajImie";
            txtSzukajImie.Size = new Size(100, 23);
            txtSzukajImie.TabIndex = 31;
            txtSzukajImie.TextChanged += txtSzukajImie_TextChanged;
            // 
            // txtSzukajTelefon
            // 
            txtSzukajTelefon.Location = new Point(122, 254);
            txtSzukajTelefon.Name = "txtSzukajTelefon";
            txtSzukajTelefon.Size = new Size(100, 23);
            txtSzukajTelefon.TabIndex = 32;
            txtSzukajTelefon.TextChanged += txtSzukajTelefon_TextChanged;
            // 
            // cmbLekarz
            // 
            cmbLekarz.Location = new Point(12, 390);
            cmbLekarz.Name = "cmbLekarz";
            cmbLekarz.Size = new Size(121, 23);
            cmbLekarz.TabIndex = 33;
            // 
            // dtpDataWizyty
            // 
            dtpDataWizyty.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpDataWizyty.Format = DateTimePickerFormat.Custom;
            dtpDataWizyty.Location = new Point(153, 390);
            dtpDataWizyty.Name = "dtpDataWizyty";
            dtpDataWizyty.Size = new Size(200, 23);
            dtpDataWizyty.TabIndex = 34;
            // 
            // txtCelWizyty
            // 
            txtCelWizyty.Location = new Point(374, 390);
            txtCelWizyty.Name = "txtCelWizyty";
            txtCelWizyty.Size = new Size(100, 23);
            txtCelWizyty.TabIndex = 35;
            // 
            // btnUmowWizyte
            // 
            btnUmowWizyte.Location = new Point(490, 390);
            btnUmowWizyte.Name = "btnUmowWizyte";
            btnUmowWizyte.Size = new Size(75, 23);
            btnUmowWizyte.TabIndex = 36;
            btnUmowWizyte.Text = "Zapisz";
            btnUmowWizyte.Click += btnUmowWizyte_Click;
            // 
            // txtSzukajWlascicielaImie
            // 
            txtSzukajWlascicielaImie.Location = new Point(671, 917);
            txtSzukajWlascicielaImie.Name = "txtSzukajWlascicielaImie";
            txtSzukajWlascicielaImie.Size = new Size(100, 23);
            txtSzukajWlascicielaImie.TabIndex = 41;
            txtSzukajWlascicielaImie.TextChanged += txtSzukajWlascicielaImie_TextChanged;
            // 
            // txtSzukajWlascicielaNazwisko
            // 
            txtSzukajWlascicielaNazwisko.Location = new Point(777, 917);
            txtSzukajWlascicielaNazwisko.Name = "txtSzukajWlascicielaNazwisko";
            txtSzukajWlascicielaNazwisko.Size = new Size(100, 23);
            txtSzukajWlascicielaNazwisko.TabIndex = 42;
            txtSzukajWlascicielaNazwisko.TextChanged += txtSzukajWlascicielaNazwisko_TextChanged;
            // 
            // txtSzukajWlascicielaTelefon
            // 
            txtSzukajWlascicielaTelefon.Location = new Point(883, 917);
            txtSzukajWlascicielaTelefon.Name = "txtSzukajWlascicielaTelefon";
            txtSzukajWlascicielaTelefon.Size = new Size(100, 23);
            txtSzukajWlascicielaTelefon.TabIndex = 43;
            txtSzukajWlascicielaTelefon.TextChanged += txtSzukajWlascicielaTelefon_TextChanged;
            // 
            // txtNowyWlascicielImie
            // 
            txtNowyWlascicielImie.Location = new Point(16, 608);
            txtNowyWlascicielImie.Name = "txtNowyWlascicielImie";
            txtNowyWlascicielImie.Size = new Size(100, 23);
            txtNowyWlascicielImie.TabIndex = 37;
            // 
            // txtNowyWlascicielNazwisko
            // 
            txtNowyWlascicielNazwisko.Location = new Point(131, 608);
            txtNowyWlascicielNazwisko.Name = "txtNowyWlascicielNazwisko";
            txtNowyWlascicielNazwisko.Size = new Size(100, 23);
            txtNowyWlascicielNazwisko.TabIndex = 38;
            // 
            // txtNowyWlascicielTelefon
            // 
            txtNowyWlascicielTelefon.Location = new Point(253, 608);
            txtNowyWlascicielTelefon.Name = "txtNowyWlascicielTelefon";
            txtNowyWlascicielTelefon.Size = new Size(100, 23);
            txtNowyWlascicielTelefon.TabIndex = 39;
            // 
            // btnDodajWlasciciela
            // 
            btnDodajWlasciciela.Location = new Point(365, 608);
            btnDodajWlasciciela.Name = "btnDodajWlasciciela";
            btnDodajWlasciciela.Size = new Size(75, 23);
            btnDodajWlasciciela.TabIndex = 40;
            btnDodajWlasciciela.Text = "Dodaj";
            btnDodajWlasciciela.Click += btnDodajWlasciciela_Click;
            // 
            // label31
            // 
            label31.Location = new Point(0, 0);
            label31.Name = "label31";
            label31.Size = new Size(100, 23);
            label31.TabIndex = 0;
            // 
            // label30
            // 
            label30.Location = new Point(0, 0);
            label30.Name = "label30";
            label30.Size = new Size(100, 23);
            label30.TabIndex = 0;
            // 
            // label29
            // 
            label29.Location = new Point(0, 0);
            label29.Name = "label29";
            label29.Size = new Size(100, 23);
            label29.TabIndex = 0;
            // 
            // label35
            // 
            label35.Location = new Point(0, 0);
            label35.Name = "label35";
            label35.Size = new Size(100, 23);
            label35.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(-1, 757);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(248, 217);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 44;
            pbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 45;
            label1.Text = "Imię";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 55);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 46;
            label2.Text = "Rasa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 54);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 47;
            label3.Text = "Gatunek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 55);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 48;
            label4.Text = "Data urodzenia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 55);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 49;
            label5.Text = "ID Właściciela";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 236);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 50;
            label6.Text = "Imię";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 236);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 51;
            label7.Text = "Numer telefonu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 372);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 52;
            label8.Text = "Lekarz";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 372);
            label9.Name = "label9";
            label9.Size = new Size(118, 15);
            label9.TabIndex = 53;
            label9.Text = "Data i godzina wizyty";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(374, 372);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 54;
            label10.Text = "Powód wizyty";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 590);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 55;
            label11.Text = "Imię";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(131, 590);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 56;
            label12.Text = "Nazwisko";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(253, 590);
            label13.Name = "label13";
            label13.Size = new Size(91, 15);
            label13.TabIndex = 57;
            label13.Text = "Numer telefonu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(671, 899);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 58;
            label14.Text = "Imię";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(777, 899);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 59;
            label15.Text = "Nazwisko";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(883, 899);
            label16.Name = "label16";
            label16.Size = new Size(91, 15);
            label16.TabIndex = 60;
            label16.Text = "Numer telefonu";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(989, 824);
            label17.Name = "label17";
            label17.Size = new Size(59, 15);
            label17.TabIndex = 61;
            label17.Text = "Właściciel";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(989, 465);
            label18.Name = "label18";
            label18.Size = new Size(95, 15);
            label18.TabIndex = 62;
            label18.Text = "Najbliższe wizyty";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(989, 4);
            label19.Name = "label19";
            label19.Size = new Size(89, 15);
            label19.TabIndex = 63;
            label19.Text = "Lista pacjentów";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 22);
            label20.Name = "label20";
            label20.Size = new Size(63, 15);
            label20.TabIndex = 64;
            label20.Text = "Rejestracja";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(12, 202);
            label21.Name = "label21";
            label21.Size = new Size(104, 15);
            label21.TabIndex = 65;
            label21.Text = "Wyszukaj pacjenta";
           
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(12, 340);
            label22.Name = "label22";
            label22.Size = new Size(78, 15);
            label22.TabIndex = 66;
            label22.Text = "Umów wizytę";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(16, 554);
            label23.Name = "label23";
            label23.Size = new Size(97, 15);
            label23.TabIndex = 67;
            label23.Text = "Dodaj właściciela";
            
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(671, 865);
            label24.Name = "label24";
            label24.Size = new Size(115, 15);
            label24.TabIndex = 68;
            label24.Text = "Wyszukaj właściciela";
            // 
            // btnUsunPacjenta
            // 
            btnUsunPacjenta.Location = new Point(1530, 456);
            btnUsunPacjenta.Name = "btnUsunPacjenta";
            btnUsunPacjenta.Size = new Size(107, 23);
            btnUsunPacjenta.TabIndex = 69;
            btnUsunPacjenta.Text = "Usuń Pacjenta";
            btnUsunPacjenta.UseVisualStyleBackColor = true;
            btnUsunPacjenta.Click += btnUsunPacjenta_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1649, 971);
            Controls.Add(btnUsunPacjenta);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            Controls.Add(dataGridView1);
            Controls.Add(dgvNajblizszeWizyty);
            Controls.Add(dataGridView2);
            Controls.Add(txtImie);
            Controls.Add(txtRasa);
            Controls.Add(cmbGatunek);
            Controls.Add(txtOwnerId);
            Controls.Add(dtpDataUrodzenia);
            Controls.Add(btnDodaj);
            Controls.Add(txtSzukajImie);
            Controls.Add(txtSzukajTelefon);
            Controls.Add(cmbLekarz);
            Controls.Add(dtpDataWizyty);
            Controls.Add(txtCelWizyty);
            Controls.Add(btnUmowWizyte);
            Controls.Add(txtNowyWlascicielImie);
            Controls.Add(txtNowyWlascicielNazwisko);
            Controls.Add(txtNowyWlascicielTelefon);
            Controls.Add(btnDodajWlasciciela);
            Controls.Add(txtSzukajWlascicielaImie);
            Controls.Add(txtSzukajWlascicielaNazwisko);
            Controls.Add(txtSzukajWlascicielaTelefon);
            Name = "Form1";
            Text = "VetCare Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNajblizszeWizyty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dgvNajblizszeWizyty;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TextBox txtImie;
		private System.Windows.Forms.TextBox txtRasa;
		private System.Windows.Forms.ComboBox cmbGatunek;
		private System.Windows.Forms.TextBox txtOwnerId;
		private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
		private System.Windows.Forms.Button btnDodaj;
		private System.Windows.Forms.TextBox txtSzukajImie;
		private System.Windows.Forms.TextBox txtSzukajTelefon;
		private System.Windows.Forms.ComboBox cmbLekarz;
		private System.Windows.Forms.DateTimePicker dtpDataWizyty;
		private System.Windows.Forms.TextBox txtCelWizyty;
		private System.Windows.Forms.Button btnUmowWizyte;
		private System.Windows.Forms.TextBox txtSzukajWlascicielaImie;
		private System.Windows.Forms.TextBox txtSzukajWlascicielaNazwisko;
		private System.Windows.Forms.TextBox txtSzukajWlascicielaTelefon;
		private System.Windows.Forms.TextBox txtNowyWlascicielImie;
		private System.Windows.Forms.TextBox txtNowyWlascicielNazwisko;
		private System.Windows.Forms.TextBox txtNowyWlascicielTelefon;
		private System.Windows.Forms.Button btnDodajWlasciciela;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label35;
        private PictureBox pbLogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button btnUsunPacjenta;
    }
}