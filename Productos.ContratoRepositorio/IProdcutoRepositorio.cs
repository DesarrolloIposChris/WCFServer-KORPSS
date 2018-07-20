using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;

using Productos.Dominio;


namespace Productos.ContratoRepositorio
{
    public interface IProdcutoRepositorio
    {
        IEnumerable<Producto> ListarProductos();
        Producto ObtenerProductoID(string Id);
        IEnumerable<Producto> ObtenerProductoNombre(string Nombre);
        IEnumerable<Producto> ObtenerProductoPrecio(string Precio);
        IEnumerable<Producto> ObtenerProductoDescripcion(string Descripcion);
        bool EliminarProdcuto(string Id);
        Producto ActualizarProducto(Producto producto);
        Producto CrearProducto(Producto producto);       
    }
}
