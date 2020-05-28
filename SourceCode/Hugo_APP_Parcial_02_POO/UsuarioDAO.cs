using System;
using System.Collections.Generic;
using System.Data;

namespace Hugo_APP_Parcial_02_POO.Modelo
{
    public class UsuarioDAO{
    
        
        public static List<Usuario> getLista()
                 {
                     string sql = "select * from APPUSER";
         
                     DataTable dt = ConexionBD.realizarConsulta(sql);
         
                     List<Usuario> lista = new List<Usuario>();
                     foreach (DataRow fila in dt.Rows)
                     {
                         Usuario u = new Usuario();
                         u.fullname = fila[1].ToString();
                         u.username = fila[2].ToString();
                         u.password = fila[3].ToString();
                         u.usertype = Convert.ToBoolean(fila[4].ToString());
         
                         lista.Add(u);
                     }
                     return lista;
                 }
        
        
        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update APPUSER set password='{0}' where username='{1}';",
                nuevaContra, usuario);
            
            ConexionBD.realizarAccion(sql);
        }

        public static void crearNuevo(string NombreCompleto, string usuario, string Contraseña)
        {
            string sql = String.Format(
                "insert into APPUSER(fullname, username, password, usertype) " +
                "values('{0}', '{1}', '{2}', false);",
            NombreCompleto, usuario,Contraseña);
            ConexionBD.realizarAccion(sql);
        }
        public static void crearNuevoUsuarioAdmin(string usuario)
        {
            string sql = String.Format(
                "insert into APPUSER(fullname, username, password, usertype)" +
                "values('{0}', '{1}', '{2}', false);",
                usuario, usuario,usuario);
            
            ConexionBD.realizarAccion(sql);
        }
        public static void crearNuevoEmpresa(string NombreEmpresa, string descripcion)
                {
                    string sql = String.Format(
                        "insert into BUSINESS( name, description) " +
                        "values('{0}', '{1}');",
                    NombreEmpresa, descripcion);
                    ConexionBD.realizarAccion(sql);
                }
        public static void crearNuevoProducto(string Empresa, string nombrep)
        {
            var negocios = ConexionBD.realizarConsulta("SELECT * FROM BUSINESS");

                                  string query = $"SELECT idBusiness FROM BUSINESS WHERE name = '{Empresa.ToString()}'";
                                  var dt = ConexionBD.realizarConsulta(query);
                                  var idp = dt.Rows[0];
                                  var idp2 = Convert.ToString(idp[0].ToString());
                                  string sql = String.Format(
                                      "INSERT INTO PRODUCT(idBusiness, name) " +
                                      "values('{0}', '{1}');",
                                      idp2, nombrep);
                                  ConexionBD.realizarAccion(sql);
        }

        public static void actualizarPermisos(string usuario, bool admin)
        {
            string sql = String.Format(
                "update APPUSER set usertype={0}  where username={1};",
                admin ? "true" : "false", usuario);
            
            ConexionBD.realizarAccion(sql);
        }

        public static void eliminarUserPorId(string usuario)
        {
            string tquery = $"SELECT iduser FROM APPUSER WHERE username= '{usuario.ToString()}'";
            var dt = ConexionBD.realizarConsulta(tquery);
            var id = dt.Rows[0];
            var id2 = Convert.ToString(id[0].ToString());
            string sql = String.Format("DELETE FROM APPUSER WHERE idUser = {0}", id2);
            
            
            ConexionBD.realizarAccion(sql);
        }

        public static void eliminarProducto(string empresa, string nombrep)
        {
            string query = $"SELECT idBusiness FROM BUSINESS WHERE name = '{empresa.ToString()}'";
            var dt = ConexionBD.realizarConsulta(query);
            var idp = dt.Rows[0];
            var idp2 = Convert.ToString(idp[0].ToString());
            string sql = String.Format(
                "DELETE FROM PRODUCT WHERE idProduct = {0} " ,idp2 );
            ConexionBD.realizarAccion(sql);
            
            
            
        }
        public static void eliminarNegocio(string nombre)
                {
                    string tquery = $"SELECT idbusiness FROM BUSINESS WHERE name= '{nombre.ToString()}'";
                    var dt = ConexionBD.realizarConsulta(tquery);
                    var id = dt.Rows[0];
                    var id2 = Convert.ToString(id[0].ToString());
                    string sql = String.Format("DELETE FROM BUSINESS WHERE idBusiness = {0}", id2);
                    
                    
                    ConexionBD.realizarAccion(sql);
                }
    }
}