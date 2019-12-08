using System;

namespace InfoTecBackEnd.Model
{
    public class DocumentModel
    {
        public string AlumnId { get; set; }
        public int Idtipo { get; set; }
        public string url { get; set; }
        public DateTime fecha { get; set; }
        public string ComentarioAsesor { get; set; }
        public int idEstatus { get; set; }
        public string ComentarioAdmRes { get; set; }
        public int Idasesor { get; set; }
        public int idadmin { get; set; }
    }
}
