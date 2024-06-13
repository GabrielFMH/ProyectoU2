namespace Proyecto_Final_Blood_Bank
{
    partial class OPCIONES
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
            this.btnBanco = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnDonantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBanco
            // 
            this.btnBanco.BackColor = System.Drawing.Color.White;
            this.btnBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanco.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBanco.Location = new System.Drawing.Point(324, 120);
            this.btnBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(203, 121);
            this.btnBanco.TabIndex = 2;
            this.btnBanco.Text = "BANCO DE SANGRE";
            this.btnBanco.UseVisualStyleBackColor = false;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblTitulo.Location = new System.Drawing.Point(296, 34);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 27);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Escoge una opcion";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPacientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPacientes.Location = new System.Drawing.Point(64, 120);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(204, 121);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "REGISTRO PACIENTES";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPersonal.Location = new System.Drawing.Point(584, 120);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(214, 121);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "PERSONAL";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(753, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 17);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "label2";
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogOut.Location = new System.Drawing.Point(61, 43);
            this.LogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(54, 17);
            this.LogOut.TabIndex = 44;
            this.LogOut.Text = "LogOut";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnInforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInforme.ForeColor = System.Drawing.Color.White;
            this.btnInforme.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInforme.Location = new System.Drawing.Point(468, 249);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(4);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(214, 121);
            this.btnInforme.TabIndex = 45;
            this.btnInforme.Text = "INFORME";
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnDonantes
            // 
            this.btnDonantes.BackColor = System.Drawing.Color.White;
            this.btnDonantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonantes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDonantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDonantes.Location = new System.Drawing.Point(183, 249);
            this.btnDonantes.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonantes.Name = "btnDonantes";
            this.btnDonantes.Size = new System.Drawing.Size(203, 121);
            this.btnDonantes.TabIndex = 46;
            this.btnDonantes.Text = "REGISTRO DONANTES";
            this.btnDonantes.UseVisualStyleBackColor = false;
            this.btnDonantes.Click += new System.EventHandler(this.btnDonantes_Click);
            // 
            // OPCIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 405);
            this.Controls.Add(this.btnDonantes);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.btnBanco);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OPCIONES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPCIONES";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OPCIONES_Load);
            this.Resize += new System.EventHandler(this.OPCIONES_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnDonantes;
    }
}