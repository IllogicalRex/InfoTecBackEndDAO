using InfoTecBackEnd.DAO;
using InfoTecBackEnd.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTecBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectBankController: ControllerBase
    {
        ProjectBankDAO pbDao = new ProjectBankDAO();
        // GET api/values
        [HttpGet]
        public List<ProjectBankModel> Get()
        {
            return pbDao.GetAllProjects();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ProjectBankModel Get(int id)
        {
            return pbDao.GetProjectsById(id);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] ProjectBankModel project)
        {
            return pbDao.CreateProject(project);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ProjectBankModel Put(int id, [FromBody] ProjectBankModel value)
        {
            return pbDao.UpdateProject(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return pbDao.DeleteProject(id);
        }
    }
}
