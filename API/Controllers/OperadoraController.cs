using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperadoraController : ControllerBase
    {
        private ServiceOperadora _serviceOperadora = new ServiceOperadora();

        [HttpGet]
        [Route("GetOperadoras")]
        public List<Operadora> Get()
        {
            return _serviceOperadora.ObterOperadoras();
        }

        [HttpGet]
        [Route("GetOperadora/ID/{id}/", Name = "Get")]
        public Operadora Get(int id)
        {
            return _serviceOperadora.ObterOperadora(id);
        }

        [HttpPost]
        [Route("PostOperadora/")]
        public void Post(Operadora operadora)
        {
            _serviceOperadora.InserirOperadora(operadora);
        }

        [HttpPut]
        [Route("UpdateOperadora/ID/{id}/")]
        public void Put(int id, [FromBody] string value)
        {
            _serviceOperadora.AtualizarOperadora(id);
        }

        [HttpDelete]
        [Route("RemoveOperadora/ID/{id}/")]
        public void Delete(int id)
        {
            _serviceOperadora.RemoverOperadora(id);
        }
    }
}