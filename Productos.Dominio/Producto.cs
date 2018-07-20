using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Productos.Dominio
{
    [DataContract]
    public class Producto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public double Precio { get; set; }
        [DataMember]
        public string Imagen { get; set; }
    }
}
