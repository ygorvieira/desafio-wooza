using System;

using Domain.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class OperadoraTests
    {
        [TestMethod]
        public void GetDeveRetornarTodasAsOperadoras()
        {
            var service = new ServiceOperadora();
            var resultado = service.ObterOperadoras();

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void DelteDeveFalharSeIdOperadoraDiferente()
        {
            var valor = Int32.MaxValue;
            var service = new ServiceOperadora();
            var resultado = service.RemoverOperadora(valor);

            Assert.IsInstanceOfType(resultado, typeof(NotFoundResult));
        }

        [TestMethod]
        public void PutDeveFalharSeIdDoperadoraDiferente()
        {
            var valor = Int32.MaxValue;
            var service = new ServiceOperadora();
            var resultado = service.AtualizarOperadora(valor);

            Assert.IsInstanceOfType(resultado, typeof(BadRequestResult));
        }
    }
}
