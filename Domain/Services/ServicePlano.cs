using System;
using System.Collections.Generic;
using System.Text;
using Domain.Repository;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

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
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO PLANO VALUES(@CODIGO, @NOME, @MINUTOS, @FRANQUIA, @VALOR, @TIPO, @DISPONIBILIDADE @ID_OPERADORA)";
                connection.Execute(query);
            }
        }

        public Plano ObterPlano(int planoId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM PLANO WHERE CODIGO = " + planoId;
                var plano = connection.Query<Plano>(query).FirstOrDefault();

                return plano;
            }
        }

        public List<Plano> ObterPlanos()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM PLANO";
                var lstPlanos = connection.Query<Plano>(query).ToList();

                return lstPlanos;
            }
        }

        public void RemoverPlano(int planoId)
        {
            throw new NotImplementedException();
        }
    }
}
