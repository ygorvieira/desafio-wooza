using System.Collections.Generic;
using Domain;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoController : ControllerBase
    {
        private ServicePlano _servicePlano = new ServicePlano();

        [HttpGet]
        [Route("GetPlanos")]
        public List<Plano> Get()
        {
            return _servicePlano.ObterPlanos();
        }

        [HttpGet]
        [Route("GetPlano/ID/{id}/", Name = "Get")]
        public Plano Get(int id)
        {
            return _servicePlano.ObterPlano(id);
        }

        [HttpPost]
        [Route("PostPlano/")]
        public void Post(Plano plano)
        {
            _servicePlano.InserirPlano(plano);
        }

        [HttpPut]
        [Route("UpdatePlano/ID/{id}/")]
        public void Put(int id, [FromBody] string value)
        {
            _servicePlano.AtualizarPlano(id);
        }

        [HttpDelete]
        [Route("RemovePlano/ID/{id}/")]
        public void Delete(int id)
        {
            _servicePlano.RemoverPlano(id);
        }
    }
}