using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormBackup : Form
    {
        static string conexionString = "server= localhost; database= bd_genetica; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionString);
        public FormBackup()
        {
            InitializeComponent();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string dateTime = Regex.Replace(DateTime.Now.ToString(), @"\s", "");
            dateTime = Regex.Replace(dateTime, @":", "");
            dateTime = Regex.Replace(dateTime, @"/", "");

            string queryBackup = @"BACKUP DATABASE bd_genetica TO DISK = 'C:\backupsFTApp\bd_genetica" + dateTime + ".Bak' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full backup bd_genetica'";

            SqlCommand comando = new SqlCommand(queryBackup, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Backup creado");
        }
    }
}
