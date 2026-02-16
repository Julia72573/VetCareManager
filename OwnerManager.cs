using System;
using System.Data;
using System.Data.SqlClient;

namespace VetCare_Manager
{
	public class OwnerManager
	{
		private DatabaseHelper db = new DatabaseHelper();

		public int DodajWlasciciela(string imie, string nazwisko, string telefon)
		{
			string sqlCheck = "SELECT COUNT(*) FROM Owners WHERE phone = @tel";
			SqlParameter[] psCheck = { new SqlParameter("@tel", telefon) };

			DataTable dt = db.PobierzDane(sqlCheck, psCheck);
			if (Convert.ToInt32(dt.Rows[0][0]) > 0)
			{
				
				throw new Exception("Właściciel z tym numerem telefonu już istnieje w bazie!");
			}

			
			string sqlInsert = @"
                INSERT INTO Owners (firstname, lastname, phone) 
                OUTPUT INSERTED.id_owner 
                VALUES (@imie, @nazwisko, @tel)";

			SqlParameter[] psInsert = {
				new SqlParameter("@imie", imie),
				new SqlParameter("@nazwisko", nazwisko),
				new SqlParameter("@tel", telefon)
			};

			
			DataTable dtResult = db.PobierzDane(sqlInsert, psInsert);
			return Convert.ToInt32(dtResult.Rows[0][0]);
		}

		public DataTable SearchOwners(string imie, string nazwisko, string telefon)
		{
			string sql = "SELECT id_owner AS ID, firstname AS Imię, lastname AS Nazwisko, phone AS Telefon FROM Owners " +
						 "WHERE firstname LIKE @imie AND lastname LIKE @nazwisko AND phone LIKE @tel";

			SqlParameter[] ps = {
				new SqlParameter("@imie", "%" + imie + "%"),
				new SqlParameter("@nazwisko", "%" + nazwisko + "%"),
				new SqlParameter("@tel", "%" + telefon + "%")
			};
			return db.PobierzDane(sql, ps);
		}
	}
}