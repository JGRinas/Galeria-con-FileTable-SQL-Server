using CapaPresentacion.CapaData.Model;
using CapaPresentacion.CapaData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormVerTodo : Form
    {
        static string conexionString = "server= localhost; database= bd_genetica; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionString);
        public FormVerTodo()
        {
            conexion.Open();
            InitializeComponent();
            rellenarDataGrid();
        }

        public void rellenarDataGrid()
        {
 

            string sql = "SELECT stream_id, name, path_locator, parent_path_locator, file_type, creation_time, last_write_time, last_access_time, is_directory, is_offline, is_hidden, is_readonly, is_archive, is_system, is_temporary FROM VistaPublicacionArchivos_FT ";

            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable dt = new DataTable();

            data.Fill(dt);

            dataGridViewVerTodo.DataSource = dt;

            conexion.Close();
        }
    }
}
