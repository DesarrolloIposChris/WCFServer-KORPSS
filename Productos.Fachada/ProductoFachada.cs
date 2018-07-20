using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos.ContratoRepositorio;
using Productos.Dominio;
using Productos.SqlRepositorio;

namespace Productos.Fachada
{
    public class ProductoFachada : IDisposable
    {
        public Producto ObtenerProductoID(string Id)
        {
            IProdcutoRepositorio instacia = new ProductoRepositorio();
            return instacia.ObtenerProductoID(Id);
        }

        public IEnumerable<Producto> ListarProductos()
        {

            IProdcutoRepositorio instacia = new ProductoRepositorio();
            return instacia.ListarProductos();
        }
        public IEnumerable<Producto> ObtenerProductoNombre(string Nombre)

        {

            IProdcutoRepositorio instacia = new ProductoRepositorio();
            return instacia.ObtenerProductoNombre(Nombre);

        }

        public IEnumerable<Producto> ObtenerProductoPrecio(string Precio)

        {

            IProdcutoRepositorio instacia = new ProductoRepositorio();
            return instacia.ObtenerProductoPrecio(Precio);

        }

        public IEnumerable<Producto> ObtenerProductoDescripcion(string Descripcion)

        {

            IProdcutoRepositorio instacia = new ProductoRepositorio();
            return instacia.ObtenerProductoDescripcion(Descripcion);

        }

        public bool EliminarProdcuto(string Id)

        {

            IProdcutoRepositorio instacia = new ProductoRepositorio();
            return instacia.EliminarProdcuto(Id);

        }

        public Producto ActualizarProducto(Producto producto)

        {

            IProdcutoRepositorio instacia = new ProductoRepositorio();
            return instacia.ActualizarProducto(producto);

        }

        public Producto CrearProducto( Producto producto)


        {

            IProdcutoRepositorio instacia = new ProductoRepositorio();
            return instacia.CrearProducto(producto);

        }

        


        void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

namespace System.Drawing
{
    class bitmap
    {
    }
}