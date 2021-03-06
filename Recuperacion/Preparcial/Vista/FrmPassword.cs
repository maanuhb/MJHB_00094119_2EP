﻿using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

ActualizarControlers();
}

private void ActualizarControlers()
{
comboBox1.ValueMember = "Contrasena";
comboBox1.DataSource = ControladorUsuario.GetUsuarios();
comboBox1.DisplayMember = "NombreUsuario";
}
//Utilizar comando hide para cuando se presione el boton de cambiar contraseña ,se vuelva al menu login
private void Button1_Click(object sender, EventArgs e)
{
    
if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()))
{       
var obtenerUsuario = (Usuario)comboBox1.SelectedItem;

ActualizarControlers();
                
ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
txtNewPassword.Text);


}
else {MessageBox.Show("Contrasena actual incorrecta");}
//agregar funcion Hide para ocultar la ventana cuando se presione el boton, indiferentemente
//si se pudo llegar a realizar la accion o no.
//para realizar con exito el cambio, se agrego una varible frmLogin para cambiar de ventana
Hide();
FrmLogin frmlogin = new FrmLogin();
frmlogin.Show();

        }
    }
}
