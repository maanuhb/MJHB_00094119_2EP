using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hugo_APP_Parcial_02_POO.Modelo;

namespace Hugo_APP_Parcial_02_POO
{
    public partial class frmAdministradorUsuarios : Form
    {
        private Usuario username;
        public frmAdministradorUsuarios()
        {
            InitializeComponent();
           
        }

        
        private void frmMenu_Load(object sender, EventArgs e)
        {
            var usuarios = ConexionBD.realizarConsulta("SELECT username FROM APPUSER");
            var usuarios2 = new List<string>();

            foreach (DataRow dr in usuarios.Rows)
            {
                usuarios2.Add(dr[0].ToString());
            }
            cmbUsuarioAU.DataSource = usuarios2;
            
            var negocios = ConexionBD.realizarConsulta("SELECT * FROM BUSINESS");
            var negocios2 = new List<string>();

            foreach (DataRow dr in negocios.Rows)
            {
                negocios2.Add(dr[1].ToString());
            }
            cmbNegociosP.DataSource = negocios2;
            cmbNegocioPElim.DataSource = negocios2;
            cmbNE.DataSource = negocios2;
            
            var productos = 
                ConexionBD.realizarConsulta("SELECT p.idProduct, p.name FROM PRODUCT p WHERE idBusiness = 1");
            var productos2 = new List<string>();

            foreach (DataRow dr in productos.Rows)
            {
                productos2.Add(dr[0].ToString());
            }

            cmbProductos.DataSource = productos2;
            
        }

        
        private void btnCrearU_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoUsuario.Text.Length >= 4)
                {
                    UsuarioDAO.crearNuevoUsuarioAdmin(txtNuevoUsuario.Text);

                    MessageBox.Show("¡Usuario agregado exitosamente! Valores por defecto: " +
                                    "Nombre de usuario igual a usuario, contrasena igual a usuario " +
                                    "y no es administrador",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNuevoEmpleado.Clear();

                }
                else if (txtNuevoUsuario.Equals(""))
                {
                    MessageBox.Show("Por favor no ingreses espacios vacios.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else MessageBox.Show("Por favor digite un nombre de usuario con mas de 4 caracteres.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al escribir el usuario.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearU_MouseHover(object sender, EventArgs e)
        {
            btnCrearU.BackColor = btnCrearU.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }

        private void btnCrearU_MouseLeave(object sender, EventArgs e)
        {
            btnCrearU.BackColor = Color.Indigo;
        }

        private void btnActualizarD_Click(object sender, EventArgs e)
        {
            frmMenu_Load(sender,e);
            actualizarControles();
        }
        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            List<Usuario> lista = UsuarioDAO.getLista();
            
            // Tabla (data grid view)
            dtgUsuarios.DataSource = null;
            dtgUsuarios.DataSource = lista;
            // Menu desplegable (combo box)
                        cmbUsuarioAU.DataSource = null;
                        cmbUsuarioAU.ValueMember = "password";
                        cmbUsuarioAU.DisplayMember = "username";
                        cmbUsuarioAU.DataSource = lista;
        }
        private void btnActualizarD_MouseHover(object sender, EventArgs e)
        {
            btnActualizarD.BackColor = btnActualizarD.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }

        private void btnActualizarD_MouseLeave(object sender, EventArgs e)
        {
            btnActualizarD.BackColor = Color.Indigo;
        }
        
        private void cmbUsuarioAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario u = (Usuario) cmbUsuarioAU.SelectedItem;

            if (u.usertype)
                radAdministrador.Checked = true;
            else
                radUsuario.Checked = true;
            
            
        }
        private void btnGuardarAu_Click(object sender, EventArgs e)
        {
            string sql = String.Format(
                "update APPUSER set usertype={0}  where username={1};",
                Convert.ToBoolean( radAdministrador) ? "true" : "false", cmbUsuarioAU);
            
            ConexionBD.realizarAccion(sql);
            
            MessageBox.Show("¡El usuario se actualizo de forma correcta!", 
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            actualizarControles();
        }

        private void btnGuardarAu_MouseHover(object sender, EventArgs e)
        {
            btnGuardarAu.BackColor = btnGuardarAu.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }
        
        private void btnGuardarAu_MouseLeave(object sender, EventArgs e) 
         { 
             btnGuardarAu.BackColor = Color.Indigo;
         }

        private void btnEliminarAU_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas eliminar al usuario " +
                                cmbUsuarioAU.Text + "?", 
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioDAO.eliminarUserPorId(cmbUsuarioAU.Text);
                
                MessageBox.Show("¡El usuario seleccionado se elimnino de forma correcta!", 
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                btnActualizarD_Click(sender,e);
            }
        }

        private void btnEliminarAU_MouseHover(object sender, EventArgs e)
        {
            btnEliminarAU.BackColor = btnEliminarAU.BackColor == Color.Crimson ?
                Color.IndianRed: Color.Crimson;
        }

        private void btnEliminarAU_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarAU.BackColor = Color.Crimson;
        }
        
        private void btnActualizarPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                    var dt = ConexionBD.realizarConsulta(
                        "$SELECT ao.idOrder, ao.createDate," +
                             " $pr.name, au.fullname, ad.address FROM APPORDER ao," +
                             " $ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct " +
                        "$AND ao.idAddress = ad.idAddress  AND ad.idUser = au.idUser");
                   dtgPedidos.DataSource = dt;
                    MessageBox.Show("Se han obtenido los datos exitosamente");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            
        }
        private void btnActualizarPedidos_MouseHover(object sender, EventArgs e)
        {
            btnActualizarPedidos.BackColor = btnActualizarPedidos.BackColor == Color.Indigo ?
                Color.MediumPurple: Color.Indigo;
        }
        private void btnActualizarPedidos_MouseLeave(object sender, EventArgs e)
        {
            btnActualizarPedidos.BackColor = Color.Indigo;
        }
         private void btnAgregarN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNNegocio.Text.Length>=3 && txtDNegocio.Text.Length >= 6 )
                {
                    UsuarioDAO.crearNuevoEmpresa(txtNNegocio.Text, txtDNegocio.Text);
                    
                    MessageBox.Show("¡negocio agregado exitosamente! ", 
                        "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtNNegocio.Clear();
                    txtDNegocio.Clear();

                }
                else
                    MessageBox.Show("Favor digite el nombre  nombre del negocio (Longitud minima, 3 caracteres)," +
                                    " y las descripcion del mismo (longitud minima, 6 caracteres)" , 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El negocio que ha digitado, no se encuentra disponible.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         private void btnAgregarN_MouseHover(object sender, EventArgs e)
         {
             btnAgregarN.BackColor = btnAgregarN.BackColor == Color.Indigo ?
                 Color.MediumPurple: Color.Indigo;
         }

         private void btnAgregarN_MouseLeave(object sender, EventArgs e)
         {
             btnAgregarN.BackColor = Color.Indigo;
         }

         private void btnEliminarN_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("¿Estas seguro que deseas eliminar el negocio " +
                                 cmbNE.Text + "?", 
                 "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 UsuarioDAO.eliminarNegocio(cmbNE.Text);
                
                 MessageBox.Show("¡El usuario seleccionado se elimnino de forma correcta!", 
                     "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                 btnActualizarD_Click(sender,e);
             }
         }
         
         private void btnEliminarN_MouseHover(object sender, EventArgs e)
        {
            btnEliminarN.BackColor = btnEliminarN.BackColor == Color.Crimson ?
                Color.IndianRed: Color.Crimson;            

        }
        private void btnEliminarN_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarN.BackColor = Color.Crimson;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

                    try
                    {
                        if (txtProductoN.Text.Length >= 4 )
                        {
                            UsuarioDAO.crearNuevoProducto(cmbNegociosP.Text,txtProductoN.Text);
                    
                            MessageBox.Show("¡producto agregado exitosamente! ", 
                                "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                            txtProductoN.Clear();
                            

                        }
                        else
                            MessageBox.Show("Favor digite el  nombre del negocio (Longitud minima, 3 caracteres)," +
                                            " y las descripcion del mismo (longitud minima, 6 caracteres)" , 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            
        }

        private void btnAgregarProducto_MouseHover(object sender, EventArgs e)
        {
            btnAgregarProducto.BackColor = btnAgregarProducto.BackColor == Color.Crimson ?
                Color.IndianRed: Color.Crimson;
        }

        private void btnAgregarProducto_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarProducto.BackColor = Color.Indigo;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estas seguro que deseas eliminar el producto seleccionado?", 
                    "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    string query = $"SELECT idBusiness FROM BUSINESS WHERE name = '{cmbNegocioPElim.Text.ToString()}'";
                    var dt = ConexionBD.realizarConsulta(query);
                    var idp = dt.Rows[0];
                    var idp2 = Convert.ToString(idp[0].ToString());
                    string sql = String.Format(
                        "DELETE FROM PRODUCT WHERE idProduct = {0} " ,cmbProductos.Text );
                    ConexionBD.realizarAccion(sql);
                    txtProductoN.Clear();
                    MessageBox.Show("¡El producto seleccionado se elimnino de forma correcta!", 
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                    btnActualizarD_Click(sender,e);      

                }
                else
                    MessageBox.Show("Error al encontrar el producto)" , 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El producto que ha digitado, no se encuentra disponible.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarProducto_MouseHover(object sender, EventArgs e)
        {
            btnEliminarProducto.BackColor = btnEliminarProducto.BackColor == Color.Crimson ?
                Color.IndianRed: Color.Crimson;
        }

        private void btnEliminarProducto_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarProducto.BackColor = Color.Crimson;
        }

        
    }
}