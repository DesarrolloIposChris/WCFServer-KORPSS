using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos.Dominio;
using Productos.Contrato;
using Productos.Fachada;

namespace Productos.Implementacion
{
    public class ProductoService : IProductosService
    {

        public IEnumerable<Producto> ListarProductos()
        {

            using (ProductoFachada instancia = new ProductoFachada ())
            {
                return instancia.ListarProductos();
            }
        }
    public IEnumerable<Producto> ObtenerProductoNombre(string Nombre)

        {

            using (ProductoFachada instancia = new ProductoFachada ())
            {
                return instancia.ObtenerProductoNombre(Nombre);
            }

        }
    
    public IEnumerable<Producto> ObtenerProductoPrecio(string Precio)

        {

            using (ProductoFachada instancia = new ProductoFachada())
            {
                return instancia.ObtenerProductoPrecio(Precio);
            }

        }
   
    public IEnumerable<Producto> ObtenerProductoDescripcion(string Descripcion)

        {

            using (ProductoFachada instancia = new ProductoFachada())
            {
                return instancia.ObtenerProductoDescripcion(Descripcion);
            }

        }
    
    public bool EliminarProdcuto(string Id)

        {

            using (ProductoFachada instancia = new ProductoFachada())
            {
                return instancia.EliminarProdcuto(Id);
            }

        }
    
    public Producto ActualizarProducto(Producto producto)

        {

            using (ProductoFachada instancia = new ProductoFachada())
            {
                return instancia.ActualizarProducto(producto);
            }

        }
 
    public Producto CrearProducto( Producto producto)


        {

            using (ProductoFachada instancia = new ProductoFachada())
            {
                return instancia.CrearProducto(producto);
            }

        }

        public Producto ObtenerProductoID(string Id)
        {
            using (ProductoFachada instancia = new ProductoFachada())
            {
                return instancia.ObtenerProductoID(Id);
            }
        }
    }
}

