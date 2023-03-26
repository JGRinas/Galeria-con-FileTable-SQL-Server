using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormFileTable : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormFileTable()
        {
            InitializeComponent();

        }

        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(formHijo);
            panelHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void buttonVerTodo_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new FormVerTodo());
        }

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new FormVerImagenes());
        }

        private void buttonVerVideos_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new FormVerVideos());
        }

        private void buttonVerAudios_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new FormVerAudios());
        }

        private void buttonVerOtrosArchivos_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new FormOtrosArchivos());
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new FormBackup());
        }
    }
}
