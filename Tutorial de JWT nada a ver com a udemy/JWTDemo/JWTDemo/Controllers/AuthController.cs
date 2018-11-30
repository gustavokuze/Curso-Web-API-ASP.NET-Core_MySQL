using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JWTDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("token")]
        public ActionResult GetToken()
        {
            //security key
            string securityKey = "uma_chave_de_seguranca_bem_longa_pra_gente_testar_o_json_web_token-2018-11-30";
            //symmetric security key
            var symmKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            // signing credentials
            var signingCred = new SigningCredentials(symmKey, SecurityAlgorithms.HmacSha256Signature);

            //create token
            var token = new JwtSecurityToken(
                    issuer: "gks",
                    audience: "readers",
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: signingCred 
                );

            //return token
            return Ok(new JwtSecurityTokenHandler().WriteToken(token));

        }
    }
}