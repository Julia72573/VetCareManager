using System;
using System.Data;
using System.Data.SqlClient;

namespace VetCare_Manager
{
	public class DatabaseHelper
	{
		private string connString = @"Server=localhost\SQLEXPRESS; Database=Lecznica; Integrated Security=True; TrustServerCertificate=True;";

		
		public DataTable PobierzDane(string query, SqlParameter[] parameters = null)
		{
			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(query, conn);
				if (parameters != null) cmd.Parameters.AddRange(parameters);

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				return dt;
			}
		}

		
		public void ExecuteCommand(string query, SqlParameter[] parameters)
		{
			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddRange(parameters);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
	}
}