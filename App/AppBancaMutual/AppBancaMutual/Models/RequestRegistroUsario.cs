using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancaMutual.Models
{
    public class RequestRegistroUsario
    {
        public string tipoDocumentoId { get; set; }
        public string documentoIdentidad { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public DateTime fechaRegistro { get; set; }
    }
}
