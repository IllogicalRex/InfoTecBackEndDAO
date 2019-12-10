using InfoTecBackEnd.DAO;
using InfoTecBackEnd.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InfoTecBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        LoginDAO login = new LoginDAO();
        // GET api/values
        [HttpPost, Route("authalumn")]
        public IActionResult LoginAlumn([FromBody]LoginModel user)
        {
            LoginModel loginResponse = login.GetUserAlumn(user);
            if (loginResponse == null)
            {
                return Ok(new { Token = "Unauthorized" });
            }
            if (user.userName == loginResponse.userName && user.password == loginResponse.password)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:44344",
                    audience: "http://localhost:44344",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString, user = "Alumno", userName = user.userName });
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet("{userName}/{password}"), Route("authalumnAndroid")]
        public IActionResult LoginAlumnAndroid([FromQuery] string userName,[FromQuery] string password)
        {
            LoginModel user = new LoginModel();
            user.password = password;
            user.userName = userName;
            LoginModel loginResponse = login.GetUserAlumn(user);
            if (loginResponse == null)
            {
                return Ok(new { Token = "Unauthorized" });
            }
            if (user.userName == loginResponse.userName && user.password == loginResponse.password)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:44344",
                    audience: "http://localhost:44344",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString, user = "alumno", userName = user.userName });
            }
            else
            {
                return Unauthorized();
            }
        }



        [HttpPost, Route("authasesor")]
        public IActionResult LoginAsesor([FromBody]LoginModel user)
        {
            LoginModel loginResponse = login.GetUserAsesor(user);
            if (loginResponse == null)
            {
                return Ok(new { Token = "Unauthorized" });
            }
            if (user.userName == loginResponse.userName && user.password == loginResponse.password)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:44344",
                    audience: "http://localhost:44344",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString, user = "Asesor", userName = user.userName });
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost, Route("authencargado")]
        public IActionResult LoginEncargado([FromBody]LoginModel user)
        {
            LoginModel loginResponse = login.GetUserEncargado(user);
            if (loginResponse == null)
            {
                return Ok(new { Token = "Unauthorized" });
            }
            if (user.userName == loginResponse.userName && user.password == loginResponse.password)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:44344",
                    audience: "http://localhost:44344",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString, user = "Encargado de residencias", userName = user.userName });
            }
            else
            {
                return Unauthorized();
            }
        }

    }
}
