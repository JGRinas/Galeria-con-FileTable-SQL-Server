namespace CapaPresentacion
{
    partial class FormVerVideos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerVideos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewVideos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 23);
            this.panel1.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(87, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 23);
            this.labelNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 347);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.videoPlayer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 156);
            this.panel4.TabIndex = 1;
            // 
            // videoPlayer
            // 
            this.videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(0, 0);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(800, 156);
            this.videoPlayer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewVideos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 191);
            this.panel2.TabIndex = 0;
            // 
            // dataGridViewVideos
            // 
            this.dataGridViewVideos.AllowCustomTheming = false;
            this.dataGridViewVideos.AllowUserToAddRows = false;
            this.dataGridViewVideos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewVideos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVideos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVideos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVideos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewVideos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVideos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVideos.ColumnHeadersHeight = 40;
            this.dataGridViewVideos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewVideos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewVideos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewVideos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewVideos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewVideos.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewVideos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewVideos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewVideos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewVideos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewVideos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewVideos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewVideos.CurrentTheme.Name = null;
            this.dataGridViewVideos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewVideos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewVideos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewVideos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewVideos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVideos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVideos.EnableHeadersVisualStyles = false;
            this.dataGridViewVideos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewVideos.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewVideos.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewVideos.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewVideos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVideos.Name = "dataGridViewVideos";
            this.dataGridViewVideos.ReadOnly = true;
            this.dataGridViewVideos.RowHeadersVisible = false;
            this.dataGridViewVideos.RowHeadersWidth = 51;
            this.dataGridViewVideos.RowTemplate.Height = 40;
            this.dataGridViewVideos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVideos.Size = new System.Drawing.Size(800, 191);
            this.dataGridViewVideos.TabIndex = 1;
            this.dataGridViewVideos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewVideos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVideos_CellClick);
            // 
            // FormVerVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerVideos";
            this.Text = "FormVerVideos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewVideos;
    }
}