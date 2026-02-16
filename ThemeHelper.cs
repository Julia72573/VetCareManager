using System.Drawing;
using System.Windows.Forms;

namespace VetCare_Manager
{
	public static class ThemeHelper
	{ 
		public static readonly Color LightGreenBg = Color.FromArgb(240, 255, 240);
		public static readonly Color DarkBlueAccent = Color.FromArgb(45, 85, 120);
		public static readonly Color TableRowGreen = Color.FromArgb(220, 245, 220);
		public static readonly Color SelectionBlue = Color.FromArgb(70, 130, 180);

		public static void ApplyMedicalTheme(Form form)
		{
			form.BackColor = LightGreenBg;

			foreach (Control control in form.Controls)
			{
				if (control is Button btn)
				{
					btn.FlatStyle = FlatStyle.Flat;
					btn.BackColor = DarkBlueAccent;
					btn.ForeColor = Color.White;
					btn.FlatAppearance.BorderSize = 0;
					btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
				}

				if (control is Label lbl)
				{
					lbl.ForeColor = Color.FromArgb(30, 60, 30);
					lbl.Font = new Font("Segoe UI", 9, FontStyle.Regular);
				}

				if (control is DataGridView dgv)
				{
					ApplyTableStyle(dgv);
				}
			}
		}

    private static void ApplyTableStyle(DataGridView dgv)
		{
			dgv.BackgroundColor = LightGreenBg;

			dgv.BorderStyle = BorderStyle.None;
			dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

			dgv.GridColor = Color.FromArgb(200, 235, 200);

			dgv.EnableHeadersVisualStyles = false;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.RowHeadersVisible = false; 

	
			dgv.DefaultCellStyle.BackColor = Color.White;
			dgv.AlternatingRowsDefaultCellStyle.BackColor = TableRowGreen;
			dgv.DefaultCellStyle.SelectionBackColor = SelectionBlue;
			dgv.DefaultCellStyle.SelectionForeColor = Color.White;

			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = DarkBlueAccent;
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			dgv.ColumnHeadersHeight = 35;
		}
	}
}