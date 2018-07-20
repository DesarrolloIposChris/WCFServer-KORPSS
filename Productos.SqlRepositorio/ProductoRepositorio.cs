using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos.Contrato;
using Productos.Dominio;
using Productos.ContratoRepositorio;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using Productos.ConexionBaseDatos;

namespace Productos.SqlRepositorio
{
    public class ProductoRepositorio : IProdcutoRepositorio
    {
        public Producto ObtenerProductoID(string Id)
        {
            using (IDbConnection conexion = new MySqlConnection(ConexionStatic.CONNECTION))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("Idp", Id);
                var producto = conexion.QuerySingle<Producto>("ObtenerProductoId", param: parametros ,commandType: CommandType.StoredProcedure);
                return producto;
            }
        }

        public IEnumerable<Producto> ListarProductos()
        {

            using (IDbConnection conexion = new MySqlConnection(ConexionStatic.CONNECTION))
            {
                    conexion.Open();
                var Producto = conexion.Query<Producto>("ListarProductos", commandType: CommandType.StoredProcedure);
                
                return Producto;

            }
        }
        public IEnumerable<Producto> ObtenerProductoNombre(string Nombre)

        {

            using (IDbConnection conexion = new MySqlConnection(ConexionStatic.CONNECTION))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("Nombrep", Nombre);

                var Producto = conexion.Query<Producto>("ObtenerProductoNombre", param: parametros, commandType: CommandType.StoredProcedure);
                return Producto;
            }

        }

        public IEnumerable<Producto> ObtenerProductoPrecio(string Precio)

        {

            using (IDbConnection conexion = new MySqlConnection(ConexionStatic.CONNECTION))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("Preciop", Precio);

                var Producto = conexion.Query<Producto>("ObtenerProductoPrecio", param: parametros, commandType: CommandType.StoredProcedure);
                return Producto;

            }

        }

        public IEnumerable<Producto> ObtenerProductoDescripcion(string Descripcion)

        {

            using (IDbConnection conexion = new MySqlConnection(ConexionStatic.CONNECTION))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("Descripcionp", "%"+Descripcion+"%");

                var Producto = conexion.Query<Producto>("ObtenerProductoDescripcion", param: parametros, commandType: CommandType.StoredProcedure);
                return Producto;

            }

        }

         bool IProdcutoRepositorio.EliminarProdcuto(string Id)

        {

            using (IDbConnection conexion = new MySqlConnection(ConexionStatic.CONNECTION))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("Idp", Id);

                var result = conexion.Execute("EliminarProducto", param: parametros, commandType: CommandType.StoredProcedure);
                return result<0;


            }
        }

        public Producto ActualizarProducto(Producto producto)

        {
            using (IDbConnection conexion = new MySqlConnection(ConexionStatic.CONNECTION))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("Nombrep", producto.Nombre);
                parametros.Add("Descripcionp", producto.Descripcion);
                parametros.Add("Preciop", producto.Precio);
                parametros.Add("Imagenp", producto.Imagen);
                parametros.Add("Idp", producto.Id);

                var result = conexion.Execute("ActualizarProducto", param: parametros, commandType: CommandType.StoredProcedure);

                return result > 0 ? producto : new Producto();
            }

        }

        public Producto CrearProducto(Producto producto)


        {

            using (IDbConnection conexion = new MySqlConnection(ConexionStatic.CONNECTION))
            {
                conexion.Open();
                var Patametros = new DynamicParameters();
                Patametros.Add("Nombrep", producto.Nombre);
                Patametros.Add("Descripcionp", producto.Descripcion);
                Patametros.Add("Preciop", producto.Precio);
                Patametros.Add("Imagenp", producto.Imagen);

                var Result = conexion.Execute("CrearRegistro", param: Patametros, commandType: CommandType.StoredProcedure);
                return producto;
                


            }

        }
    }
}
