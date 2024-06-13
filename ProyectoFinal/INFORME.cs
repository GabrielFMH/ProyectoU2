using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proyecto_Final_Blood_Bank
{
    public partial class INFORME : Form
    {
        public INFORME()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            lblVolver.MouseEnter += OnMouseEnter;
            lblVolver.MouseLeave += OnMouseLeave;
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void INFORME_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = LOGIN.NombreUsuario;

            formOriginalSize = this.Size;
            ReclblTitulo = new Rectangle(lblTitulo.Location.X, lblTitulo.Location.Y, lblTitulo.Width, lblTitulo.Height);
            ReclblVolver = new Rectangle(lblVolver.Location.X, lblVolver.Location.Y, lblVolver.Width, lblVolver.Height);
            ReclblUsuario = new Rectangle(lblUsuario.Location.X, lblUsuario.Location.Y, lblUsuario.Width, lblUsuario.Height);
            RecbtnGraph1 = new Rectangle(chartStock.Location.X, chartStock.Location.Y, chartStock.Width, chartStock.Height);
            RecbtnGraph2 = new Rectangle(chartPedido.Location.X, chartPedido.Location.Y, chartPedido.Width, chartPedido.Height);



            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            string comando = "Select * from BancoDeSangre";

            SqlCommand cmd = new SqlCommand(comando, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                string junto = dr["Tipo"].ToString() + dr["Rh"].ToString();

                chartStock.Series["Stock"].IsValueShownAsLabel = true;

                chartStock.Series["Stock"].Points.AddXY(junto, dr["Litros"]);

            }
            con.Close();

            SqlConnection con2 = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
            SqlConnection con3 = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
            con2.Open();
            con3.Open();
            string comando2 = "Select * from Pacientes";
            string comando3 = "Select * from BancoDeSangre";
            SqlCommand cmd2 = new SqlCommand(comando2, con2);
            SqlCommand cmd3 = new SqlCommand(comando3, con3);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            SqlDataReader dr3 = cmd3.ExecuteReader();
            Dictionary<string, int> data = new Dictionary<string, int>();
            data["O+"] = 0;
            data["O-"] = 0;
            data["A+"] = 0;
            data["A-"] = 0;
            data["B+"] = 0;
            data["B-"] = 0;
            data["AB+"] = 0;
            data["AB-"] = 0;
            while (dr2.Read())
            {
                string junto = dr2["Tipo"].ToString() + dr2["Rh"].ToString();

                data[junto]++;

            }

            while (dr3.Read())
            {
                string junto = dr3["Tipo"].ToString() + dr3["Rh"].ToString();

                chartPedido.Series["Solicitada"].IsValueShownAsLabel = true;
                if (data[junto] > 0)
                {
                    chartPedido.Series["Solicitada"].Points.AddXY(junto, data[junto]);
                }
            }
            con2.Close();
            con3.Close();
        
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            string temp_usuario = lblUsuario.Text;
            string comando = "Select estado from Personal where Usuario='" + temp_usuario + "'";
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.ExecuteNonQuery();

            SqlDataReader datos;
            datos = cmd.ExecuteReader();
            if (datos.Read())
            {

                if (datos["estado"].ToString() == "N")
                {
                    new OPCIONES_1().Show();
                    this.Hide();
                }
                else if (datos["estado"].ToString() == "P")
                {
                    new OPCIONES_2().Show();
                    this.Hide();
                }
                else if (datos["estado"].ToString() == "A")
                {
                    new OPCIONES().Show();
                    this.Hide();
                }

            }


            con.Close();
        }
        private Size formOriginalSize;
        // Resolucion Dinamica
        private Rectangle ReclblTitulo;
        private Rectangle ReclblVolver;
        private Rectangle ReclblUsuario;
        private Rectangle RecbtnGraph1;
        private Rectangle RecbtnGraph2;
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        }


        private void OnMouseEnter(object sender, EventArgs e)
        {
            lblVolver.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            lblVolver.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void INFORME_Resize_1(object sender, EventArgs e)
        {
            resizeControl(ReclblUsuario, lblUsuario);
            resizeControl(ReclblVolver, lblVolver);
            resizeControl(ReclblTitulo, lblTitulo);
            resizeControl(RecbtnGraph2, chartPedido);
            resizeControl(RecbtnGraph1, chartStock);
        }
    }
}
