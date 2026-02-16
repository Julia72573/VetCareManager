using System;
using System.Data;
using System.Data.SqlClient;

namespace VetCare_Manager
{
	public class PetManager
	{
		private DatabaseHelper db = new DatabaseHelper();
		public DataTable GetAllPets()
		{
			string sql = @"
                SELECT 
                    p.id_pet, 
                    p.firstname AS [Imię Pacjenta], 
                    p.birthday_date AS [Data Urodzenia],
                    o.firstname + ' ' + o.lastname AS [Właściciel],
                    p.species AS [Gatunek],
                    p.breed AS [Rasa]
                FROM Pets p
                JOIN Owners o ON p.id_owner = o.id_owner";

			return db.PobierzDane(sql);
		}
		public DataTable SearchPets(string imie, string telefon)
		{
			string sql = @"
                SELECT p.id_pet, p.firstname AS [Imię], p.birthday_date AS [Data], 
                       o.firstname + ' ' + o.lastname AS [Właściciel], 
                       p.species AS [Gatunek], p.breed AS [Rasa], o.phone AS [Telefon]
                FROM Pets p JOIN Owners o ON p.id_owner = o.id_owner
                WHERE p.firstname LIKE @imie AND o.phone LIKE @tel";

			SqlParameter[] ps = {
				new SqlParameter("@imie", "%" + imie + "%"),
				new SqlParameter("@tel", "%" + telefon + "%")
			};

			return db.PobierzDane(sql, ps);
		}
		public void AddPet(string imie, string rasa, string gatunek, DateTime dataUrodzenia, string ownerId)
		{
			string sql = "INSERT INTO Pets (firstname, breed, species, birthday_date, id_owner) " +
						 "VALUES (@imie, @rasa, @gatunek, @data, @ownerId)";

			SqlParameter[] ps = {
				new SqlParameter("@imie", imie),
				new SqlParameter("@rasa", rasa),
				new SqlParameter("@gatunek", gatunek),
				new SqlParameter("@data", dataUrodzenia),
				new SqlParameter("@ownerId", ownerId)
			};

			db.ExecuteCommand(sql, ps);
		}
		public void DeletePet(int idPet)
		{
			
			string sql = @"
                DELETE FROM Visits WHERE id_pet = @id;
                DELETE FROM Pets WHERE id_pet = @id;";

			SqlParameter[] ps = {
				new SqlParameter("@id", idPet)
			};

			try
			{
				
				db.ExecuteCommand(sql, ps);
			}
			catch (Exception ex)
			{
				throw new Exception("Błąd podczas usuwania pacjenta i jego wizyt: " + ex.Message);
			}
		}
	}
}