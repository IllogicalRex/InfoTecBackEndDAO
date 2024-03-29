using InfoTecBackEnd.DAO;
using InfoTecBackEnd.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace InfoTecBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AsesorController:ControllerBase
    {
        AsesorDAO asesorDAO = new AsesorDAO();
        [HttpGet("{id}")]
        [EnableCors("AllowOrigin")]
        [Authorize]
        public AsesorModel getAsesor(string id)
        {
            return asesorDAO.getAsesor(id);
        }

    } 
}