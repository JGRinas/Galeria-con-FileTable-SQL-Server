namespace CapaPresentacion
{
    partial class FormVerAudios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerAudios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewAudios = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).BeginInit();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.audioPlayer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 230);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewAudios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 117);
            this.panel3.TabIndex = 3;
            // 
            // dataGridViewAudios
            // 
            this.dataGridViewAudios.AllowCustomTheming = false;
            this.dataGridViewAudios.AllowUserToAddRows = false;
            this.dataGridViewAudios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAudios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAudios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAudios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAudios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAudios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAudios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAudios.ColumnHeadersHeight = 40;
            this.dataGridViewAudios.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewAudios.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewAudios.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAudios.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewAudios.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAudios.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewAudios.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewAudios.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewAudios.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewAudios.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAudios.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewAudios.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewAudios.CurrentTheme.Name = null;
            this.dataGridViewAudios.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAudios.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewAudios.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAudios.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewAudios.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAudios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAudios.EnableHeadersVisualStyles = false;
            this.dataGridViewAudios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewAudios.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewAudios.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewAudios.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewAudios.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAudios.Name = "dataGridViewAudios";
            this.dataGridViewAudios.ReadOnly = true;
            this.dataGridViewAudios.RowHeadersVisible = false;
            this.dataGridViewAudios.RowHeadersWidth = 51;
            this.dataGridViewAudios.RowTemplate.Height = 40;
            this.dataGridViewAudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAudios.Size = new System.Drawing.Size(800, 117);
            this.dataGridViewAudios.TabIndex = 1;
            this.dataGridViewAudios.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewAudios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAudios_CellClick);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(87, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(43, 23);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "DER";
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
            // audioPlayer
            // 
            this.audioPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioPlayer.Enabled = true;
            this.audioPlayer.Location = new System.Drawing.Point(0, 0);
            this.audioPlayer.Name = "audioPlayer";
            this.audioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("audioPlayer.OcxState")));
            this.audioPlayer.Size = new System.Drawing.Size(800, 230);
            this.audioPlayer.TabIndex = 0;
            // 
            // FormVerAudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerAudios";
            this.Text = "FormVerAudios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewAudios;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer audioPlayer;
    }
}