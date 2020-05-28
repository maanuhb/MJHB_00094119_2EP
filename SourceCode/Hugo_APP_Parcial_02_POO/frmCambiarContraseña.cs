using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hugo_APP_Parcial_02_POO.Modelo;

namespace Hugo_APP_Parcial_02_POO
{
    public partial class frmCambiarContraseña : Form
    {
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }
        private void btnCambiarContraCC_Click(object sender, EventArgs e)
        {
           bool verificarContra = rtbNCCC.Text.Equals(rtbRepetirContra.Text);
           bool contraNueva = rtbRepetirContra.Text.Length > 0;
           

           if (verificarContra && contraNueva)
           {
               try
               {
                   UsuarioDAO.actualizarContra(cmbUserCC.Text, rtbRepetirContra.Text);
                   MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                       "Gracias por su tiempo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                   this.Close();
               }
               catch (Exception)
               {
                   MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           }
           else
               MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
            var assignatures = ConexionBD.realizarConsulta("SELECT username FROM APPUSER");
            var assignatureCombo = new List<string>();

            foreach (DataRow dr in assignatures.Rows)
            {
                assignatureCombo.Add(dr[0].ToString());
            }

            cmbUserCC.DataSource = assignatureCombo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicioSesion ventana = new frmInicioSesion();
            ventana.Show();
            this.Hide();
        }

        private void btnVolver_MouseHover(object sender, EventArgs e)
        {
            btnVolver.BackColor = btnVolver.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.Indigo;
        }

        private void btnCambiarContraCC_MouseHover(object sender, EventArgs e)
        {
            btnCambiarContraCC.BackColor = btnCambiarContraCC.BackColor == Color.Indigo ?
                            Color.MediumPurple: Color.Indigo;
        }

        private void btnCambiarContraCC_MouseLeave(object sender, EventArgs e)
        {
            btnCambiarContraCC.BackColor = Color.Indigo;
        }
    }
}