using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos.Dominio;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.IO;

namespace Productos.Contrato
{
    [ServiceContract]
    public interface IProductosService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/ListarProductos", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Producto> ListarProductos();


        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ObtenerProductoNombre/{Nombre}", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Producto> ObtenerProductoNombre(string Nombre);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/ObtenerProductoPrecio/{Precio}", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Producto> ObtenerProductoPrecio(string Precio);


        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ObtenerProductoDescripcion/{Descripcion}", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Producto> ObtenerProductoDescripcion(string Descripcion);


        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE", UriTemplate = "/EliminarProdcuto/{Id}", BodyStyle = WebMessageBodyStyle.Bare)]
        bool EliminarProdcuto(string Id);


        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "/ActualizarProducto", BodyStyle = WebMessageBodyStyle.Bare)]
        Producto ActualizarProducto(Producto producto);


        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "/CrearProducto", BodyStyle = WebMessageBodyStyle.Bare)]
        Producto CrearProducto(Producto producto);

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "GET", UriTemplate = "/ObtenerProductoId/{Id}", BodyStyle = WebMessageBodyStyle.Bare)]

        Producto ObtenerProductoID(string Id);
        
    }
}
