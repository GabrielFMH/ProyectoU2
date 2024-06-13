using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_Blood_Bank
{
    public partial class RegistroDonantes : Form
    {
        public RegistroDonantes()
        {
            InitializeComponent();
            //COMBO BOX NO EDITABLE
            cmbRH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            lblVolver.MouseEnter += OnMouseEnter;
            lblVolver.MouseLeave += OnMouseLeave;

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void RegistroDonantes_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = LOGIN.NombreUsuario;
            CargarGrilla();



            formOriginalSize = this.Size;
            ReclblVolver = new Rectangle(lblVolver.Location.X, lblVolver.Location.Y, lblVolver.Width, lblVolver.Height);
            ReclblTitulo = new Rectangle(lblTitulo.Location.X, lblTitulo.Location.Y, lblTitulo.Width, lblTitulo.Height);
            ReclblUsuario = new Rectangle(lblUsuario.Location.X, lblUsuario.Location.Y, lblUsuario.Width, lblUsuario.Height);
            ReclblDni = new Rectangle(lblDni.Location.X, lblDni.Location.Y, lblDni.Width, lblDni.Height);
            RectxtDni = new Rectangle(txtDni.Location.X, txtDni.Location.Y, txtDni.Width, txtDni.Height);
            RecFactorRh = new Rectangle(lblFactorRH.Location.X, lblFactorRH.Location.Y, lblFactorRH.Width, lblFactorRH.Height);
            RectxtFactorRh = new Rectangle(cmbRH.Location.X, cmbRH.Location.Y, cmbRH.Width, cmbRH.Height);
            ReclblNombre = new Rectangle(lblNombre.Location.X, lblNombre.Location.Y, lblNombre.Width, lblNombre.Height);
            RectxtNombre = new Rectangle(txtNombre.Location.X, txtNombre.Location.Y, txtNombre.Width, txtNombre.Height);
            ReclblFecha = new Rectangle(lblFechaHora.Location.X, lblFechaHora.Location.Y, lblFechaHora.Width, lblFechaHora.Height);
            RectxtFecha = new Rectangle(txtFechayHora.Location.X, txtFechayHora.Location.Y, txtFechayHora.Width, txtFechayHora.Height);
            ReclblApellido = new Rectangle(lblApellido.Location.X, lblApellido.Location.Y, lblApellido.Width, lblApellido.Height);
            RectxtApellido = new Rectangle(txtApellido.Location.X, txtApellido.Location.Y, txtApellido.Width, txtApellido.Height);
            ReclblCondicion = new Rectangle(lblCondicion.Location.X, lblCondicion.Location.Y, lblCondicion.Width, lblCondicion.Height);
            RecrbSi = new Rectangle(rbSi.Location.X, rbSi.Location.Y, rbSi.Width, rbSi.Height);
            ReclblTipodeSangre = new Rectangle(lblTipoSangre.Location.X, lblTipoSangre.Location.Y, lblTipoSangre.Width, lblTipoSangre.Height);
            ReccmbTipodeSangre = new Rectangle(cmbTipoDeSangre.Location.X, cmbTipoDeSangre.Location.Y, cmbTipoDeSangre.Width, cmbTipoDeSangre.Height);
            RecrbNo = new Rectangle(rbNo.Location.X, rbNo.Location.Y, rbNo.Width, rbNo.Height);
            ReclblLitros = new Rectangle(lblLitros.Location.X, lblLitros.Location.Y, lblLitros.Width, lblLitros.Height);
            RectxtLitros = new Rectangle(txtLitros.Location.X, txtLitros.Location.Y, txtLitros.Width, txtLitros.Height);
            RecbtnRegistrar = new Rectangle(btnRegistrar.Location.X, btnRegistrar.Location.Y, btnRegistrar.Width, btnRegistrar.Height);
            RecbtnLimpiar = new Rectangle(btnLimpiar.Location.X, btnLimpiar.Location.Y, btnLimpiar.Width, btnLimpiar.Height);
            RecbtnModificar = new Rectangle(btnModificar.Location.X, btnModificar.Location.Y, btnModificar.Width, btnModificar.Height);
            RecdgvDonantes = new Rectangle(dgvDonantes.Location.X, dgvDonantes.Location.Y, dgvDonantes.Width, dgvDonantes.Height);

        }


        private void OnMouseEnter(object sender, EventArgs e)
        {
            lblVolver.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            lblVolver.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }



        private void CargarGrilla()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
            string consulta = "Select * from Donantes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvDonantes.DataSource = dt;

        }

        private void Limpiar()
        {
            txtApellido.Clear();
            txtDni.Clear();
            txtNombre.Clear();
            rbNo.Checked = false;
            rbSi.Checked = false;
            cmbRH.SelectedIndex = -1;
            cmbTipoDeSangre.SelectedIndex = -1;

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            txtFechayHora.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string login;
            try
            {
                login = "SELECT * FROM Donantes WHERE dni = '" + int.Parse(txtDni.Text) + "'";                
                SqlConnection con1 = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");

                con1.Open();
                SqlCommand cmd1 = new SqlCommand(login, con1);
                cmd1.ExecuteNonQuery();
                SqlDataReader reader = cmd1.ExecuteReader();

                if (reader.Read() || txtDni.Text.Length != 8)
                {
                    MessageBox.Show("Error al registar paciente", "Banco de Sangre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
                    try
                    {
                        //restriccion para llenar los campos
                        if (txtDni.Text != null && txtNombre.Text != null && txtApellido.Text != null &&
                            cmbTipoDeSangre.SelectedIndex != -1 && cmbRH.SelectedIndex != -1 && rbSi.Checked!=true && rbNo.Checked==true)
                        {



                            con.Open();
                            string consulta = "insert into DONANTES values(" + txtDni.Text + ",'" +
                                txtNombre.Text + "','" + txtApellido.Text + "','"  + cmbTipoDeSangre.Text + "','" + cmbRH.Text + "','" + txtLitros.Text + "')";
                            SqlCommand comando = new SqlCommand(consulta, con);
                            comando.ExecuteNonQuery();

                            MessageBox.Show("Registros alterados con exito.", "Banco de Sangre",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string temporal = cmbTipoDeSangre.Text + cmbRH.Text;
                            double temporal2 = Convert.ToDouble(txtLitros.Text);

                            SqlConnection con2= new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
                            string cmd = "Update BancoDeSangre set Litros=(Select Litros from BancoDeSangre where Tipo='" + cmbTipoDeSangre.Text + "' and Rh='" + cmbRH.Text + "')+0.5 where Tipo='" + cmbTipoDeSangre.Text+"' and Rh='" + cmbRH.Text + "'";
                            con2.Open();
                            SqlCommand ejecucion=new SqlCommand(cmd, con2);
                            ejecucion.ExecuteNonQuery();
                            con2.Close();

                            con.Close();
                        }
                        else
                        {
                            if (rbSi.Checked == true)
                            {
                                MessageBox.Show("No se puede donar sangre de pacientes que padecen una condicion.", "Banco de Sangre",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Completar los todos los campos.", "Banco de Sangre",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }



                        }

                        CargarGrilla();
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    Limpiar();
                }
            }
            catch
            {
                MessageBox.Show("Datos incorrectos", "Banco de Sangre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Rectangle ReclblVolver;
        private Rectangle ReclblTitulo;
        private Rectangle ReclblUsuario;
        private Rectangle ReclblDni;
        private Rectangle RectxtDni;
        private Rectangle RecFactorRh;
        private Rectangle RectxtFactorRh;
        private Rectangle ReclblNombre;
        private Rectangle RectxtNombre;
        private Rectangle ReclblFecha;
        private Rectangle RectxtFecha;
        private Rectangle ReclblApellido;
        private Rectangle RectxtApellido;
        private Rectangle ReclblCondicion;
        private Rectangle RecrbSi;
        private Rectangle ReclblTipodeSangre;
        private Rectangle ReccmbTipodeSangre;
        private Rectangle RecrbNo;
        private Rectangle RecbtnRegistrar;
        private Rectangle RecbtnLimpiar;
        private Rectangle RecbtnModificar;
        private Rectangle RecdgvDonantes;
        private Rectangle ReclblLitros;
        private Rectangle RectxtLitros;
        private Size formOriginalSize;


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

        private void RegistroDonantes_Resize(object sender, EventArgs e)
        {
            resizeControl(ReclblVolver, lblVolver);
            resizeControl(ReclblTitulo, lblTitulo);
            resizeControl(ReclblUsuario, lblUsuario);
            resizeControl(ReclblDni, lblDni);
            resizeControl(RectxtDni, txtDni);
            resizeControl(RecFactorRh, lblFactorRH);
            resizeControl(RectxtFactorRh, cmbRH);
            resizeControl(ReclblNombre, lblNombre);
            resizeControl(RectxtNombre, txtNombre);
            resizeControl(ReclblFecha, lblFechaHora);
            resizeControl(RectxtFecha, txtFechayHora);
            resizeControl(ReclblApellido, lblApellido);
            resizeControl(RectxtApellido, txtApellido);
            resizeControl(ReclblCondicion, lblCondicion);
            resizeControl(RectxtLitros, txtLitros);
            resizeControl(ReclblLitros, lblLitros);
            resizeControl(ReclblTipodeSangre, lblTipoSangre);
            resizeControl(ReccmbTipodeSangre, cmbTipoDeSangre);
            resizeControl(RecrbNo, rbNo);
            resizeControl(RecrbSi, rbSi);
            resizeControl(RecbtnRegistrar, btnRegistrar);
            resizeControl(RecbtnLimpiar, btnLimpiar);
            resizeControl(RecbtnModificar, btnModificar);
            resizeControl(RecdgvDonantes, dgvDonantes);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string comando = "Delete from Donantes where dni ='" + txtDni.Text + "'";
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Se ha eliminado con exito.", "Banco de Sangre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();
            CargarGrilla();

        }

        private void dgvDonantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDni.Text = Convert.ToString(dgvDonantes.CurrentRow.Cells["dni"].Value);
            txtNombre.Text = Convert.ToString(dgvDonantes.CurrentRow.Cells["nombre"].Value);
            txtApellido.Text = Convert.ToString(dgvDonantes.CurrentRow.Cells["apellido"].Value);
            string RH = Convert.ToString(dgvDonantes.CurrentRow.Cells["rh"].Value);
            string Tipo = Convert.ToString(dgvDonantes.CurrentRow.Cells["tipo"].Value);

            if (RH.Equals("+"))
            {

                cmbRH.SelectedIndex = 0;

            }
            else
            {
                cmbRH.SelectedIndex = 1;


            }

            if (Tipo.Equals("A"))
            {

                cmbTipoDeSangre.SelectedIndex = 0;

            }
            else if (Tipo.Equals("B"))
            {
                cmbTipoDeSangre.SelectedIndex = 1;
            }
            else if (Tipo.Equals("O"))
            {
                cmbTipoDeSangre.SelectedIndex = 2;
            }
            else
            {
                cmbTipoDeSangre.SelectedIndex = 3;
            }
        }
    }


}
