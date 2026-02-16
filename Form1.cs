using System;
using System.Data;
using System.Windows.Forms;

namespace VetCare_Manager
{
	public partial class Form1 : Form
	{
		private DatabaseHelper db = new DatabaseHelper();
		private VisitManager visitManager = new VisitManager();
		private OwnerManager ownerManager = new OwnerManager();
		private PetManager petManager = new PetManager();

		public Form1()
		{
			InitializeComponent();
			ThemeHelper.ApplyMedicalTheme(this);
			RefreshAll();
		}

		private void RefreshAll() { ZaladujDaneZBazy(); OdswiezWizyty(); ZaladujLekarzy(); }

		private void SetupGrid(DataGridView dgv, DataTable dt, string hideCol = null)
		{
			dgv.DataSource = dt;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			if (hideCol != null && dgv.Columns.Contains(hideCol)) dgv.Columns[hideCol].Visible = false;
		}

		private void ZaladujDaneZBazy() => SetupGrid(dataGridView1, petManager.GetAllPets(), "id_pet");
		private void OdswiezWizyty() => SetupGrid(dgvNajblizszeWizyty, visitManager.GetUpcomingVisits());
		private void SzukajPacjenta() => SetupGrid(dataGridView1, petManager.SearchPets(txtSzukajImie.Text, txtSzukajTelefon.Text), "id_pet");
		private void SzukajWlasciciela() => SetupGrid(dataGridView2, ownerManager.SearchOwners(txtSzukajWlascicielaImie.Text, txtSzukajWlascicielaNazwisko.Text, txtSzukajWlascicielaTelefon.Text));

		private void ZaladujLekarzy()
		{
			cmbLekarz.DataSource = visitManager.GetVetsForCombo();
			cmbLekarz.DisplayMember = "Nazwisko";
			cmbLekarz.ValueMember = "id_vet";
		}

		private void btnDodaj_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtImie.Text) || string.IsNullOrEmpty(txtOwnerId.Text))
			{ MessageBox.Show("Wpisz imiê i ID w³aœciciela!"); return; }

			petManager.AddPet(txtImie.Text, txtRasa.Text, cmbGatunek.Text, dtpDataUrodzenia.Value, txtOwnerId.Text);
			ZaladujDaneZBazy();
			MessageBox.Show("Pomyœlnie zarejestrowano!");
		}

		private void btnUsunPacjenta_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow == null) return;
			int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_pet"].Value);
			if (MessageBox.Show("Usun¹æ pacjenta i jego wizyty?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				petManager.DeletePet(id);
				RefreshAll();
			}
		}

		private void btnUmowWizyte_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow == null || cmbLekarz.SelectedValue == null) return;
			int idLekarza = (int)cmbLekarz.SelectedValue;
			int idPacjenta = (int)dataGridView1.CurrentRow.Cells["id_pet"].Value;
			DateTime termin = dtpDataWizyty.Value;
			termin = new DateTime(termin.Year, termin.Month, termin.Day, termin.Hour, termin.Minute, 0);

			if (visitManager.CzyLekarzWolny(idLekarza, termin))
			{
				visitManager.ZapiszWizyte(idPacjenta, idLekarza, termin, txtCelWizyty.Text);
				OdswiezWizyty();
			}
			else MessageBox.Show("Termin zajêty!");
		}

		private void btnDodajWlasciciela_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNowyWlascicielImie.Text) || string.IsNullOrWhiteSpace(txtNowyWlascicielTelefon.Text)) return;
			try
			{
				int id = ownerManager.DodajWlasciciela(txtNowyWlascicielImie.Text, txtNowyWlascicielNazwisko.Text, txtNowyWlascicielTelefon.Text);
				txtOwnerId.Text = id.ToString();
				txtNowyWlascicielImie.Clear(); txtNowyWlascicielNazwisko.Clear(); txtNowyWlascicielTelefon.Clear();
				SzukajWlasciciela();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		private void txtSzukajImie_TextChanged(object sender, EventArgs e) => SzukajPacjenta();
		private void txtSzukajTelefon_TextChanged(object sender, EventArgs e) => SzukajPacjenta();
		private void txtSzukajWlascicielaImie_TextChanged(object sender, EventArgs e) => SzukajWlasciciela();
		private void txtSzukajWlascicielaNazwisko_TextChanged(object sender, EventArgs e) => SzukajWlasciciela();
		private void txtSzukajWlascicielaTelefon_TextChanged(object sender, EventArgs e) => SzukajWlasciciela();

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
				txtOwnerId.Text = dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString();
		}
	}
}