using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hugo_APP_Parcial_02_POO.Modelo;

namespace Hugo_APP_Parcial_02_POO
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }
      
        private void btnRegistrarseNuevo_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (rtbNCRU.Text.Length>=3 && rtbUsuarioN.Text.Length >= 3&& rtbCr.Text.Length>=5)
                {
                    UsuarioDAO.crearNuevo(rtbNCRU.Text, rtbUsuarioN.Text, rtbCr.Text);
                    
                    MessageBox.Show("¡Usuario agregado exitosamente! ", 
                        "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    rtbUsuarioN.Clear();
                    
                }
                else
                    MessageBox.Show("Favor digite su nombre completo (Longitud minima, 3 caracteres)," +
                                    " un usuario (longitud minima, 3 caracteres) y una contraseña " +
                                    "(Longitud minima, 5 caracteres)" , 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarseNuevo_MouseHover(object sender, EventArgs e)
        {
            btnRegistrarseNuevo.BackColor = btnRegistrarseNuevo.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }

        private void btnRegistrarseNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarseNuevo.BackColor = Color.Indigo;
        }

        private void btnVolverRU_Click(object sender, EventArgs e)
        {
            frmInicioSesion ventana = new frmInicioSesion();
            ventana.Show();
            this.Hide();
        }

        private void btnVolverRU_MouseHover(object sender, EventArgs e)
        {
            btnVolverRU.BackColor = btnVolverRU.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }

        private void btnVolverRU_MouseLeave(object sender, EventArgs e)
        {
            btnVolverRU.BackColor = Color.Indigo;
        }
    }
}