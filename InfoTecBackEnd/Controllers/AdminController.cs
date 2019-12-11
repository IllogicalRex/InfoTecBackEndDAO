using InfoTecBackEnd.DAO;
using InfoTecBackEnd.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace InfoTecBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController:ControllerBase
    {
        AdminDAO adminDao = new AdminDAO();
        [HttpGet("{id}")]
        [EnableCors("AllowOrigin")]
        [Authorize]
        public AdminModel GetAdminInfo(string id)
        {
            return adminDao.GetAdminInfo(id);
        }
    }

}