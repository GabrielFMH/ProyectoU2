namespace Proyecto_Final_Blood_Bank
{
    partial class RegistroDonantes
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
            this.components = new System.ComponentModel.Container();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblVolver = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.dgvDonantes = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtFechayHora = new System.Windows.Forms.TextBox();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.cmbRH = new System.Windows.Forms.ComboBox();
            this.lblFactorRH = new System.Windows.Forms.Label();
            this.cmbTipoDeSangre = new System.Windows.Forms.ComboBox();
            this.lblTipoSangre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(617, 175);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 29);
            this.btnModificar.TabIndex = 66;
            this.btnModificar.Text = "Eliminar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVolver.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblVolver.Location = new System.Drawing.Point(27, 19);
            this.lblVolver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(47, 17);
            this.lblVolver.TabIndex = 65;
            this.lblVolver.Text = "Volver";
            this.lblVolver.Click += new System.EventHandler(this.lblVolver_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblUsuario.Location = new System.Drawing.Point(662, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 17);
            this.lblUsuario.TabIndex = 64;
            this.lblUsuario.Text = "Nombre";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblTitulo.Location = new System.Drawing.Point(212, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(341, 27);
            this.lblTitulo.TabIndex = 63;
            this.lblTitulo.Text = "REGISTRO DE DONANTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDni.Font = new System.Drawing.Font("MS UI Gothic", 7.8F);
            this.txtDni.Location = new System.Drawing.Point(123, 54);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(241, 18);
            this.txtDni.TabIndex = 62;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblDni.Location = new System.Drawing.Point(27, 54);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(36, 17);
            this.lblDni.TabIndex = 61;
            this.lblDni.Text = "DNI:";
            // 
            // dgvDonantes
            // 
            this.dgvDonantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonantes.Location = new System.Drawing.Point(46, 219);
            this.dgvDonantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDonantes.Name = "dgvDonantes";
            this.dgvDonantes.RowHeadersWidth = 51;
            this.dgvDonantes.RowTemplate.Height = 24;
            this.dgvDonantes.Size = new System.Drawing.Size(653, 277);
            this.dgvDonantes.TabIndex = 60;
            this.dgvDonantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonantes_CellContentClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLimpiar.Location = new System.Drawing.Point(518, 174);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 29);
            this.btnLimpiar.TabIndex = 59;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(411, 174);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 29);
            this.btnRegistrar.TabIndex = 58;
            this.btnRegistrar.Text = "Registrar Paciente";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtFechayHora
            // 
            this.txtFechayHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtFechayHora.Enabled = false;
            this.txtFechayHora.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechayHora.Location = new System.Drawing.Point(543, 84);
            this.txtFechayHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechayHora.Name = "txtFechayHora";
            this.txtFechayHora.Size = new System.Drawing.Size(176, 23);
            this.txtFechayHora.TabIndex = 57;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFechaHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblFechaHora.Location = new System.Drawing.Point(453, 84);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(92, 17);
            this.lblFechaHora.TabIndex = 56;
            this.lblFechaHora.Text = "Fecha y Hora:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCondicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblCondicion.Location = new System.Drawing.Point(453, 117);
            this.lblCondicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(74, 17);
            this.lblCondicion.TabIndex = 54;
            this.lblCondicion.Text = "Condicion:";
            // 
            // txtLitros
            // 
            this.txtLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtLitros.Enabled = false;
            this.txtLitros.Font = new System.Drawing.Font("MS UI Gothic", 7.8F);
            this.txtLitros.Location = new System.Drawing.Point(124, 185);
            this.txtLitros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(241, 18);
            this.txtLitros.TabIndex = 53;
            this.txtLitros.Text = "0.5";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLitros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblLitros.Location = new System.Drawing.Point(22, 185);
            this.lblLitros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(101, 17);
            this.lblLitros.TabIndex = 52;
            this.lblLitros.Text = "Litros a Donar:";
            // 
            // cmbRH
            // 
            this.cmbRH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbRH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRH.Font = new System.Drawing.Font("MS UI Gothic", 7.8F);
            this.cmbRH.FormattingEnabled = true;
            this.cmbRH.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbRH.Location = new System.Drawing.Point(543, 54);
            this.cmbRH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRH.Name = "cmbRH";
            this.cmbRH.Size = new System.Drawing.Size(176, 18);
            this.cmbRH.TabIndex = 51;
            // 
            // lblFactorRH
            // 
            this.lblFactorRH.AutoSize = true;
            this.lblFactorRH.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFactorRH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblFactorRH.Location = new System.Drawing.Point(453, 53);
            this.lblFactorRH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactorRH.Name = "lblFactorRH";
            this.lblFactorRH.Size = new System.Drawing.Size(72, 17);
            this.lblFactorRH.TabIndex = 50;
            this.lblFactorRH.Text = "Factor RH:";
            // 
            // cmbTipoDeSangre
            // 
            this.cmbTipoDeSangre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbTipoDeSangre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipoDeSangre.Font = new System.Drawing.Font("MS UI Gothic", 7.8F);
            this.cmbTipoDeSangre.FormattingEnabled = true;
            this.cmbTipoDeSangre.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.cmbTipoDeSangre.Location = new System.Drawing.Point(123, 150);
            this.cmbTipoDeSangre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoDeSangre.Name = "cmbTipoDeSangre";
            this.cmbTipoDeSangre.Size = new System.Drawing.Size(241, 18);
            this.cmbTipoDeSangre.TabIndex = 49;
            // 
            // lblTipoSangre
            // 
            this.lblTipoSangre.AutoSize = true;
            this.lblTipoSangre.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTipoSangre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblTipoSangre.Location = new System.Drawing.Point(17, 149);
            this.lblTipoSangre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoSangre.Name = "lblTipoSangre";
            this.lblTipoSangre.Size = new System.Drawing.Size(105, 17);
            this.lblTipoSangre.TabIndex = 48;
            this.lblTipoSangre.Text = "Tipo de Sangre:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtApellido.Font = new System.Drawing.Font("MS UI Gothic", 7.8F);
            this.txtApellido.Location = new System.Drawing.Point(123, 117);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 18);
            this.txtApellido.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNombre.Font = new System.Drawing.Font("MS UI Gothic", 7.8F);
            this.txtNombre.Location = new System.Drawing.Point(123, 84);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 18);
            this.txtNombre.TabIndex = 46;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblApellido.Location = new System.Drawing.Point(23, 117);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 17);
            this.lblApellido.TabIndex = 45;
            this.lblApellido.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblNombre.Location = new System.Drawing.Point(23, 84);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 17);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombres:";
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.rbSi.Location = new System.Drawing.Point(543, 119);
            this.rbSi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(37, 21);
            this.rbSi.TabIndex = 67;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.rbNo.Location = new System.Drawing.Point(617, 119);
            this.rbNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(44, 21);
            this.rbNo.TabIndex = 68;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // RegistroDonantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 537);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbSi);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.dgvDonantes);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtFechayHora);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.cmbRH);
            this.Controls.Add(this.lblFactorRH);
            this.Controls.Add(this.cmbTipoDeSangre);
            this.Controls.Add(this.lblTipoSangre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "RegistroDonantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroDonantes";
            this.Load += new System.EventHandler(this.RegistroDonantes_Load);
            this.Resize += new System.EventHandler(this.RegistroDonantes_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.DataGridView dgvDonantes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtFechayHora;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.ComboBox cmbRH;
        private System.Windows.Forms.Label lblFactorRH;
        private System.Windows.Forms.ComboBox cmbTipoDeSangre;
        private System.Windows.Forms.Label lblTipoSangre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Timer Hora;
    }
}