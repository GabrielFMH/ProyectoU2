namespace Proyecto_Final_Blood_Bank
{
    partial class OPCIONES_1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Label();
            this.btnDonantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblTitulo.Location = new System.Drawing.Point(213, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 27);
            this.lblTitulo.TabIndex = 26;
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
            this.btnPacientes.Location = new System.Drawing.Point(127, 150);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(153, 98);
            this.btnPacientes.TabIndex = 25;
            this.btnPacientes.Text = "REGISTRO DE PACIENTES";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblNombre.Location = new System.Drawing.Point(473, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 17);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "lblNombre";
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogOut.Location = new System.Drawing.Point(70, 48);
            this.LogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(54, 17);
            this.LogOut.TabIndex = 45;
            this.LogOut.Text = "LogOut";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // btnDonantes
            // 
            this.btnDonantes.BackColor = System.Drawing.Color.White;
            this.btnDonantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonantes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDonantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDonantes.Location = new System.Drawing.Point(317, 150);
            this.btnDonantes.Name = "btnDonantes";
            this.btnDonantes.Size = new System.Drawing.Size(152, 98);
            this.btnDonantes.TabIndex = 47;
            this.btnDonantes.Text = "REGISTRO DONANTES";
            this.btnDonantes.UseVisualStyleBackColor = false;
            this.btnDonantes.Click += new System.EventHandler(this.btnDonantes_Click);
            // 
            // OPCIONES_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDonantes);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OPCIONES_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPCIONES_1";
            this.Load += new System.EventHandler(this.OPCIONES_1_Load);
            this.Resize += new System.EventHandler(this.OPCIONES_1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Button btnDonantes;
    }
}