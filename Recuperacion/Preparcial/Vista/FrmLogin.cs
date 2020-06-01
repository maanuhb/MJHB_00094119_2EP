using System;
using System.Drawing;
using System.Windows.Forms;
using Preparcial.Controlador;
using Preparcial.Modelo;
using Preparcial.Vista;

namespace Preparcial
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Evento Load del FrmLogin, para cargar la imagen del logo UCA desde la carpeta root
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            PoblarControlers();
        }
        
        // Metodo para poblar el comboBox con todos los usuarios, asignando el value member y display member desde
        // las PROPIEDADES de la clase Usuario, deben ser publicas y llamarse igual para que funcione, ademas
        // primero se asigna el ValueMember, luego DisplayMember, y por ultimo el DataSource, sino tira excepcion
        // nombre de variable "contrasenia" a "contrasena"
        private void PoblarControlers()
        {
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "Contrasena";
            cmbUser.DisplayMember = "Nombre";
            cmbUser.DataSource = ControladorUsuario.GetUsuarios();
        }

        // EventHandler para detectar el click para inciar sesion
        private void BttnLogin_Click(object sender, EventArgs e)
        {
            // Si la contrasena del textBox es igual al SelectedValue del comboBox, entonces iniciar sesion
            if (textBox1.Text.Equals(cmbUser.SelectedValue.ToString()))
            {
                // Crear ventana principal enviandole el item seleccionado
                // Recordar que SelectedItem devuelve un objeto, con polimorfismo se convierte a Usuario
                FrmMain frmMain = new FrmMain((Usuario)cmbUser.SelectedItem);
                // Esconder frmLogin y mostrar frmMain
                Hide();
                frmMain.Show();
            }
            else
                MessageBox.Show("Contrasena incorrecta");
        }

        // EventHandler para invocar al form de actualizar contrasena
        // Utilizar comando hide, para ocultar la ventana y mostrar el frmPassword
        // se utiliza la funcion poblar controles para actualizar los usuarios
        // cambio de show a showdialog
        private void BttnUpdatePassword_Click(object sender, EventArgs e)
        {
            FrmPassword frmPassword = new FrmPassword();
            frmPassword.ShowDialog();
            Hide();
            PoblarControlers();

        }
    }
}
