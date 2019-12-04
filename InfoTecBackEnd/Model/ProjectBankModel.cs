using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTecBackEnd.Model
{
    public class ProjectBankModel
    {
        public int IdBproy { get; set; }
        public string tipo_proyecto { get; set; }
        public string nombre_proy { get; set; }
        public string nombre_emp { get; set; }
        public string nombre_cont { get; set; }
        public string tel_empre { get; set; }
        public string correo_empre { get; set; }
        public int num_vacantes { get; set; }
        public string direccion_empre { get; set; }
    }
}
