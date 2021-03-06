﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaWebAPI.Models;
using MinhaWebAPI.Util;

namespace MinhaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            DAL dal = new DAL();
            var dados = dal.RetornarDados($"Select * from cliente WHERE id={id}");
            return dados.Rows[0]["Nome"].ToString();
        }

        // POST api/values
        [HttpPost]
        [Route("RegistrarCliente")]
        public string RegistrarCliente([FromBody] ClienteModel dados)
        {
            try
            {
                dados.RegistrarCliente();
                return "Cliente registrado com sucesso!";
            }
            catch (Exception ex)
            {
                return $"Ocorreu o seguinte erro ao tentar registrar o cliente: { ex.Message }";
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
