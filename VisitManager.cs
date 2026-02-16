using System;
using System.Data;
using System.Data.SqlClient;

namespace VetCare_Manager
{
	public class VisitManager
	{
		private DatabaseHelper db = new DatabaseHelper();

		public bool CzyLekarzWolny(int idLekarza, DateTime dataWizyty)
		{
			string sql = "SELECT COUNT(*) FROM Visits WHERE id_vet = @idVet AND visit_date = @data";

			SqlParameter[] ps = {
				new SqlParameter("@idVet", idLekarza),
				new SqlParameter("@data", dataWizyty)
			};

			DataTable dt = db.PobierzDane(sql, ps);

			return Convert.ToInt32(dt.Rows[0][0]) == 0;
		}
		public void ZapiszWizyte(int idPacjenta, int idLekarza, DateTime data, string cel)
		{
			string sql = "INSERT INTO Visits (id_pet, id_vet, visit_date, reason) VALUES (@idPet, @idVet, @data, @cel)";

			SqlParameter[] ps = {
				new SqlParameter("@idPet", idPacjenta),
				new SqlParameter("@idVet", idLekarza),
				new SqlParameter("@data", data),
				new SqlParameter("@cel", cel)
			};

			db.ExecuteCommand(sql, ps);
		}
		public DataTable GetUpcomingVisits()
		{
			string sql = @"
                SELECT 
                    v.visit_date AS [Data i Godzina], 
                    p.firstname AS [Pacjent], 
                    v.reason AS [Cel wizyty], 
                    vt.firstname + ' ' + vt.lastname AS [Lekarz]
                FROM Visits v 
                JOIN Pets p ON v.id_pet = p.id_pet 
                JOIN Vets vt ON v.id_vet = vt.id_vet 
                WHERE v.visit_date >= GETDATE()
                ORDER BY v.visit_date ASC";

			return db.PobierzDane(sql);
		}
		public DataTable GetVetsForCombo()
		{
			return db.PobierzDane("SELECT id_vet, firstname + ' ' + lastname AS Nazwisko FROM Vets");
		}
	}
}