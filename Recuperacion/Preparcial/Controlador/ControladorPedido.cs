using System;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorPedido
    {
        //modificacion de la funcion getpedidosUsuarioTable: modificar nombreArticulo por nombreArt
        public static DataTable GetPedidosUsuarioTable(string id)
        {
            DataTable pedidos = null;
           
            try
            {
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreArt, p.cantidad, i.precio" +
                                                      " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                                      " WHERE p.idArticulo = i.idArticulo" +
                                                      " AND p.idUsuario = u.idUsuario" +
                                                      $" AND u.idUsuario = {id}");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }
        //moidificacion de getPedidos table: modificar nombreArticulo por nombreArt,
        public static DataTable GetPedidosTable()
        {
            DataTable pedidos = null;

            try
            {
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreArt, p.cantidad, i.precio" +
                                                      " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                                      " WHERE p.idArticulo = i.idArticulo" +
                                                      " AND p.idUsuario = u.idUsuario");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        public static void HacerPedido(string idUsuario, string idArticulo, string cantidad)
        {
            try
            {
                ConexionBD.EjecutarComando("INSERT INTO PEDIDO(idUsuario, idArticulo, cantidad) " +
                                           $"VALUES({idUsuario}, {idArticulo}, {cantidad})");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}