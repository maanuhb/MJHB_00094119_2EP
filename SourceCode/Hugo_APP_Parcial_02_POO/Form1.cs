using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hugo_APP_Parcial_02_POO.Modelo;

namespace Hugo_APP_Parcial_02_POO
{
    public partial class frmInicioSesion : Form
    {
        private UserControl current = null;
        private Usuario username;
        public frmInicioSesion()
        {
            InitializeComponent();
           
        }
        private void poblarControles()
        {
            var assignatures = ConexionBD.realizarConsulta("SELECT username FROM APPUSER");
            var assignatureCombo = new List<string>();

            foreach (DataRow dr in assignatures.Rows)
            {
                assignatureCombo.Add(dr[0].ToString());
            }

            cmbUsuario.DataSource = assignatureCombo;
        }
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {    
            
            string query = $"SELECT password FROM APPUSER WHERE username = '{cmbUsuario.SelectedItem.ToString()}'";
            string tquery = $"SELECT usertype FROM APPUSER WHERE username= '{cmbUsuario.SelectedItem.ToString()}'";
            //string query2 = $"SELECT administrador FROM USUARIO WHERE nombre_usuario = '{comboBox1.SelectedItem.ToString()}'";

            var dt = ConexionBD.realizarConsulta(query);
            var contra = dt.Rows[0];
            var contra2 = Convert.ToString(contra[0].ToString());
            var t = ConexionBD.realizarConsulta((tquery));
            var admin = t.Rows[0];
            var admin2 = Convert.ToBoolean(admin[0].ToString());

            try
            {
                if (rtbContraseña.Text.Equals(""))
                {
                    MessageBox.Show("Ha ocurrido un error, ingrese un valor nuevamente. ");
                }

                else if (contra2.Equals(rtbContraseña.Text) )
                {
                    MessageBox.Show("Redireccionando a nueva ventana");
                    if ( admin2)
                    {
                        frmAdministradorUsuarios ventana = new frmAdministradorUsuarios();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        
                        frmServicioUsuarios ventana = new frmServicioUsuarios();
                        ventana.Show();
                        this.Hide();
                    }
                 
            
                }
                else MessageBox.Show("Contraseña Incorrecta, vuelve a escribirla. ");    
                    
                    
          
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        private void btnInicioSesion_MouseHover(object sender, EventArgs e)
        {
            btnInicioSesion.BackColor = btnInicioSesion.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }

        private void btnInicioSesion_MouseLeave(object sender, EventArgs e)
        {
            btnInicioSesion.BackColor = Color.Indigo;
        }
        
        private void btnRegístrate_Click(object sender, EventArgs e)
        {
           frmRegistrarUsuario VentanaRU = new frmRegistrarUsuario();
                       VentanaRU.ShowDialog();
                       poblarControles();
        }
        
        private void btnRegístrate_MouseHover(object sender, EventArgs e)
        {
            btnRegístrate.BackColor = btnRegístrate.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }

        private void btnRegístrate_MouseLeave(object sender, EventArgs e)
        {
            btnRegístrate.BackColor = Color.Indigo;
        }
        
        private void btnContraseñaOlvidada_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña VentanaCC = new frmCambiarContraseña();
            VentanaCC.ShowDialog();
            poblarControles();
        }

        private void btnContraseñaOlvidada_MouseHover(object sender, EventArgs e)
        {
            btnContraseñaOlvidada.BackColor = btnContraseñaOlvidada.BackColor == Color.Indigo ?
                            Color.MediumPurple: Color.Indigo;
        }

        private void btnContraseñaOlvidada_MouseLeave(object sender, EventArgs e)
        {
            btnContraseñaOlvidada.BackColor = Color.Indigo;
        }


        private void rtbContraseña_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter) btnInicioSesion_Click(sender, e);
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            var assignatures = ConexionBD.realizarConsulta("SELECT username FROM APPUSER");
            var assignatureCombo = new List<string>();

            foreach (DataRow dr in assignatures.Rows)
            {
                assignatureCombo.Add(dr[0].ToString());
            }

            cmbUsuario.DataSource = assignatureCombo;
        }
    }
}