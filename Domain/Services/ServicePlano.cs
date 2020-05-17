using System;
using System.Collections.Generic;
using System.Text;
using Domain.Repository;

namespace Domain.Services
{
    public class ServicePlano : IPlanoRepository
    {
        private string connectionString = "Data Source=DESKTOP-IQVN5PC\\SQLSERVER14;Initial Catalog=DESAFIO_WOOZA;Integrated Security=True;";

        public void AtualizarPlano(int planoId)
        {
            throw new NotImplementedException();
        }

        public void InserirPlano(Plano plano)
        {
            throw new NotImplementedException();
        }

        public Plano ObterPlano(int planoId)
        {
            throw new NotImplementedException();
        }

        public List<Plano> ObterPlanos()
        {
            throw new NotImplementedException();
        }

        public void RemoverPlano(int planoId)
        {
            throw new NotImplementedException();
        }
    }
}
