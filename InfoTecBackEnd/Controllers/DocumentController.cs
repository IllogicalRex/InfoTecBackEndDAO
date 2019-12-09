using InfoTecBackEnd.DAO;
using InfoTecBackEnd.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTecBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController: ControllerBase
    {
        DocumentDAO docDao = new DocumentDAO();
        // GET api/values
        [EnableCors("AllowOrigin")]
        [Authorize]
        [HttpPost]
        public string post([FromBody] DocumentModel document)
        {
            return docDao.CreateDocument(document);
        }
        [HttpPut]
        public string uptadeDocument([FromBody] DocumentModel document)
        {
            return docDao.UpdateDocument(document);
        }

        [HttpGet("alumno/{id}")]
        public List<DocumentModel> getAlumno(string id)
        {
            return docDao.getDocumento(id);

        }
        [HttpGet("asesor/{id}")]
        public List<DocumentModel> getDocumentoAlumnoAsesor(string id)
        {
            return docDao.getDocumentoAlumnoAsesor(id);

        }

    }
}
