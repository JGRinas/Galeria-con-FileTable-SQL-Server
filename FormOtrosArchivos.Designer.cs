namespace CapaPresentacion
{
    partial class FormOtrosArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtrosArchivos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAbrirArchivo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewOtrosArchivos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtrosArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 29);
            this.panel1.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(103, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 28);
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
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAbrirArchivo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 149);
            this.panel2.TabIndex = 3;
            // 
            // buttonAbrirArchivo
            // 
            this.buttonAbrirArchivo.AllowAnimations = true;
            this.buttonAbrirArchivo.AllowMouseEffects = true;
            this.buttonAbrirArchivo.AllowToggling = false;
            this.buttonAbrirArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbrirArchivo.AnimationSpeed = 200;
            this.buttonAbrirArchivo.AutoGenerateColors = false;
            this.buttonAbrirArchivo.AutoRoundBorders = false;
            this.buttonAbrirArchivo.AutoSizeLeftIcon = true;
            this.buttonAbrirArchivo.AutoSizeRightIcon = true;
            this.buttonAbrirArchivo.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbrirArchivo.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonAbrirArchivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAbrirArchivo.BackgroundImage")));
            this.buttonAbrirArchivo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAbrirArchivo.ButtonText = "Abrir archivo";
            this.buttonAbrirArchivo.ButtonTextMarginLeft = 0;
            this.buttonAbrirArchivo.ColorContrastOnClick = 45;
            this.buttonAbrirArchivo.ColorContrastOnHover = 45;
            this.buttonAbrirArchivo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonAbrirArchivo.CustomizableEdges = borderEdges1;
            this.buttonAbrirArchivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAbrirArchivo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonAbrirArchivo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonAbrirArchivo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonAbrirArchivo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonAbrirArchivo.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirArchivo.ForeColor = System.Drawing.Color.White;
            this.buttonAbrirArchivo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbrirArchivo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonAbrirArchivo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonAbrirArchivo.IconMarginLeft = 11;
            this.buttonAbrirArchivo.IconPadding = 10;
            this.buttonAbrirArchivo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbrirArchivo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonAbrirArchivo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonAbrirArchivo.IconSize = 25;
            this.buttonAbrirArchivo.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAbrirArchivo.IdleBorderRadius = 1;
            this.buttonAbrirArchivo.IdleBorderThickness = 1;
            this.buttonAbrirArchivo.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonAbrirArchivo.IdleIconLeftImage = null;
            this.buttonAbrirArchivo.IdleIconRightImage = null;
            this.buttonAbrirArchivo.IndicateFocus = false;
            this.buttonAbrirArchivo.Location = new System.Drawing.Point(310, 8);
            this.buttonAbrirArchivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAbrirArchivo.Name = "buttonAbrirArchivo";
            this.buttonAbrirArchivo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonAbrirArchivo.OnDisabledState.BorderRadius = 1;
            this.buttonAbrirArchivo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAbrirArchivo.OnDisabledState.BorderThickness = 1;
            this.buttonAbrirArchivo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonAbrirArchivo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonAbrirArchivo.OnDisabledState.IconLeftImage = null;
            this.buttonAbrirArchivo.OnDisabledState.IconRightImage = null;
            this.buttonAbrirArchivo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonAbrirArchivo.onHoverState.BorderRadius = 1;
            this.buttonAbrirArchivo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAbrirArchivo.onHoverState.BorderThickness = 1;
            this.buttonAbrirArchivo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonAbrirArchivo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonAbrirArchivo.onHoverState.IconLeftImage = null;
            this.buttonAbrirArchivo.onHoverState.IconRightImage = null;
            this.buttonAbrirArchivo.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAbrirArchivo.OnIdleState.BorderRadius = 1;
            this.buttonAbrirArchivo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAbrirArchivo.OnIdleState.BorderThickness = 1;
            this.buttonAbrirArchivo.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonAbrirArchivo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonAbrirArchivo.OnIdleState.IconLeftImage = null;
            this.buttonAbrirArchivo.OnIdleState.IconRightImage = null;
            this.buttonAbrirArchivo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAbrirArchivo.OnPressedState.BorderRadius = 1;
            this.buttonAbrirArchivo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAbrirArchivo.OnPressedState.BorderThickness = 1;
            this.buttonAbrirArchivo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAbrirArchivo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonAbrirArchivo.OnPressedState.IconLeftImage = null;
            this.buttonAbrirArchivo.OnPressedState.IconRightImage = null;
            this.buttonAbrirArchivo.Size = new System.Drawing.Size(263, 134);
            this.buttonAbrirArchivo.TabIndex = 0;
            this.buttonAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAbrirArchivo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonAbrirArchivo.TextMarginLeft = 0;
            this.buttonAbrirArchivo.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonAbrirArchivo.UseDefaultRadiusAndThickness = true;
            this.buttonAbrirArchivo.Click += new System.EventHandler(this.buttonAbrirArchivo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewOtrosArchivos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 178);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 284);
            this.panel3.TabIndex = 4;
            // 
            // dataGridViewOtrosArchivos
            // 
            this.dataGridViewOtrosArchivos.AllowCustomTheming = false;
            this.dataGridViewOtrosArchivos.AllowUserToAddRows = false;
            this.dataGridViewOtrosArchivos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewOtrosArchivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOtrosArchivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOtrosArchivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOtrosArchivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOtrosArchivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOtrosArchivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOtrosArchivos.ColumnHeadersHeight = 40;
            this.dataGridViewOtrosArchivos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewOtrosArchivos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewOtrosArchivos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewOtrosArchivos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewOtrosArchivos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOtrosArchivos.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewOtrosArchivos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewOtrosArchivos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewOtrosArchivos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewOtrosArchivos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewOtrosArchivos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewOtrosArchivos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewOtrosArchivos.CurrentTheme.Name = null;
            this.dataGridViewOtrosArchivos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOtrosArchivos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewOtrosArchivos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewOtrosArchivos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewOtrosArchivos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOtrosArchivos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOtrosArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOtrosArchivos.EnableHeadersVisualStyles = false;
            this.dataGridViewOtrosArchivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewOtrosArchivos.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewOtrosArchivos.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewOtrosArchivos.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewOtrosArchivos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOtrosArchivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewOtrosArchivos.Name = "dataGridViewOtrosArchivos";
            this.dataGridViewOtrosArchivos.ReadOnly = true;
            this.dataGridViewOtrosArchivos.RowHeadersVisible = false;
            this.dataGridViewOtrosArchivos.RowHeadersWidth = 51;
            this.dataGridViewOtrosArchivos.RowTemplate.Height = 40;
            this.dataGridViewOtrosArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOtrosArchivos.Size = new System.Drawing.Size(900, 284);
            this.dataGridViewOtrosArchivos.TabIndex = 2;
            this.dataGridViewOtrosArchivos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewOtrosArchivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOtrosArchivos_CellClick);
            // 
            // FormOtrosArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(900, 462);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOtrosArchivos";
            this.Text = "FormOtrosArchivos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtrosArchivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewOtrosArchivos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonAbrirArchivo;
    }
}