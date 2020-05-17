using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Domain.Repository;

namespace Domain.Services
{
    public class ServiceOperadora : IOperadoraRepository
    {
        private string connectionString = "Data Source=DESKTOP-IQVN5PC\\SQLSERVER14;Initial Catalog=DESAFIO_WOOZA;Integrated Security=True;";

        public void AtualizarOperadora(int operadoraId)
        {
            throw new NotImplementedException();
        }

        public void InserirOperadora(Operadora operadora)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO OPERADORA VALUES(@ID, @NOME)";
                connection.Execute(query);
            }
        }

        public Operadora ObterOperadora(int operadoraId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM PLANO WHERE CODIGO = " + operadoraId;
                var operadora = connection.Query<Operadora>(query).FirstOrDefault();

                return operadora;
            }
        }

        public List<Operadora> ObterOperadoras()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM OPERADORA";
                var lstOperadoras = connection.Query<Operadora>(query).ToList();

                return lstOperadoras;
            }
        }

        public void RemoverOperadora(int operadoraId)
        {
            throw new NotImplementedException();
        }
    }
}
