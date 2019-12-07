using InfoTecBackEnd.DAO;
using InfoTecBackEnd.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace InfoTecBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AlumnoController:ControllerBase
    {
        AlumnoDAO alumnoDAO = new AlumnoDAO();
        [HttpGet("{id}")]
        public AlumnoModel getAlumno(string id)
        {
            return alumnoDAO.getAlumno(id);
            
        }

    }   


}