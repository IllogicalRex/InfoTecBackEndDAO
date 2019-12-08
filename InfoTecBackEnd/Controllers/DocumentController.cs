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
        [HttpPost]
        [EnableCors("AllowOrigin")]
        [Authorize]
        public string post([FromBody] DocumentModel document)
        {
            return docDao.CreateDocument(document);
        }

    }
}
