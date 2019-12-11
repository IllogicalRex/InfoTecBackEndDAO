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
        [EnableCors("AllowOrigin")]
        [Authorize]
        public string uptadeDocument([FromBody] DocumentModel document)
        {
            return docDao.UpdateDocument(document);
        }

        [HttpGet("alumno/{id}")]
        [EnableCors("AllowOrigin")]
        [Authorize]
        public List<DocumentModel> getAlumno(string id)
        {
            return docDao.getDocumento(id);

        }
        [HttpGet("asesor/{id}")]
        [EnableCors("AllowOrigin")]
        [Authorize]
        public List<DocumentModel> getDocumentoAlumnoAsesor(string id)
        {
            return docDao.getDocumentoAlumnoAsesor(id);

        }
        [HttpGet("encargado/{id}")]
        [EnableCors("AllowOrigin")]
        [Authorize]
        public List<DocumentModel> getDocumentoEncargado(string id)
        {
            return docDao.getDocumentoEncargado(id);

        }

    }
}
