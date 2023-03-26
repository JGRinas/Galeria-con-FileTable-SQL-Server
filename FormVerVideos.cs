using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormVerVideos : Form
    {
        static string conexionString = "server= localhost; database= bd_genetica; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionString);
        public FormVerVideos()
        {
            InitializeComponent();
            rellenarDataGrid();
 
        }

        public void rellenarDataGrid()
        {

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string sql = "SELECT stream_id, name, path_locator, parent_path_locator, file_type, creation_time, last_write_time, last_access_time, is_offline, is_hidden, is_readonly, is_archive FROM VistaPublicacionArchivos_FT WHERE file_type = 'mp4' or file_type = 'mov' or file_type = 'wmv' or file_type = 'avi' or file_type = 'avchd' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(sql, conexion);

                SqlDataAdapter data = new SqlDataAdapter(comando);
                conexion.Close();
                DataTable dt = new DataTable();

                data.Fill(dt);

                dataGridViewVideos.DataSource = dt;
            }
        }

        private void dataGridViewVideos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreArchivo = dataGridViewVideos.CurrentRow.Cells[1].Value.ToString();
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {


                string sql = "SELECT file_stream FROM VistaPublicacionArchivos_FT WHERE name = '" + nombreArchivo + "'";


                conexion.Open();
                SqlCommand comando = new SqlCommand(sql, conexion);

                SqlDataAdapter data = new SqlDataAdapter(comando);

                SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                reader.Read();

                int bufferSize = Convert.ToInt32(reader.GetBytes(0, 0, null, 0, 0));

                byte[] aByte = new byte[bufferSize];

                reader.GetBytes(0, 0, aByte, 0, bufferSize);

                reader.Close();
                conexion.Close();
                string fileName = @"C:\Users\juanx\Documents\FileTableApp\videos\" + nombreArchivo;
                videoPlayer.URL = null;
                if (File.Exists(fileName))
                {

                    try
                    {
                        videoPlayer.URL = fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
                else
                {
                    WriteBinaryFile(aByte, fileName);

                    try
                    {
                        videoPlayer.URL = fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                labelNombre.Text = nombreArchivo;



            }
        }

        public void WriteBinaryFile(byte[] aByte, string fileName)
        {
            int data = aByte.Length;

            //Creamos un archivo temporal, donde se guardará el documento

            string tempFileName = global::System.IO.Path.GetTempFileName();

            using (FileStream fs = new FileStream(tempFileName, FileMode.OpenOrCreate))
            {
                BinaryWriter br = new BinaryWriter(fs);

                br.Write(aByte, 0, data);

                br.Flush();

                br = null;

            }
            File.Move(tempFileName, fileName);

        }

    }
}
