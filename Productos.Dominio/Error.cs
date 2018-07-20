using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Productos.Dominio
{
    [DataContract]
    class Error
    {
        [DataMember]
        public string CodigoError { get; set; }
        [DataMember]
        public string Mensaje { get; set; }
        [DataMember]
        public string Descripcion { get; set; }

    }
}
