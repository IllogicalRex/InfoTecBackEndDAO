using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTecBackEnd.Model
{
    public class EmpresaModel{
        public int Idempresa {get; set;}
        public string nombre {get; set;}
        public string direccion {get; set;}
        public string correo_electronico {get; set;}
        public int telefono {get; set;}
        public int Idrol {get; set;}
    }
}