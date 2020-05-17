using Domain.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PlanoTests
    {
        [TestMethod]
        public void GetDeveRetornarTodasOsPlanos()
        {
            var service = new ServicePlano();
            var resultado = service.ObterPlanos();

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void DeleteDeveFalharSeIdPlanoDiferente()
        {
            var valor = int.MaxValue;
            var service = new ServicePlano();
            var resultado = service.RemoverPlano(valor);

            Assert.IsInstanceOfType(resultado, typeof(NotFoundResult));
        }

        [TestMethod]
        public void PutDeveFalharSeIdPlanoDiferente()
        {
            var valor = int.MaxValue;
            var service = new ServicePlano();
            var resultado = service.AtualizarPlano(valor);

            Assert.IsInstanceOfType(resultado, typeof(BadRequestResult));
        }
    }
}
