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

    public class EmpresaController:ControllerBase {
        EmpresaDAO empresadao = new EmpresaDAO();        

        [HttpGet]
        public List<EmpresaModel> Get()
        {
            return empresadao.getAllEmpresas();

        }        
        [HttpDelete]
        public String deleteEmpresa(int id)
        {
           return empresadao.deleteEmpresa(id);     
        }

        [HttpPost]
        public string postEmpresa([FromBody] EmpresaModel empresa){
            return empresadao.postEmpresa(empresa);    
        } 

    }

}