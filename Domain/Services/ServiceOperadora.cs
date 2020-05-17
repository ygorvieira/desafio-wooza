using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using Dapper;

using Domain.Repository;

namespace Domain.Services
{
    public class ServiceOperadora : IOperadoraRepository
    {
        private string connectionString = "Data Source=DESKTOP-IQVN5PC\\SQLSERVER14;Initial Catalog=DESAFIO_WOOZA;Integrated Security=True;";

        public int AtualizarOperadora(int operadoraId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "UPDATE OPERADORA SET (@ID, @NOME) WHERE ID = " + operadoraId;
                    connection.Execute(query);
                }

                return operadoraId;
            }
            catch (Exception e)
            {
                throw e;
            }
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
                var query = "SELECT * FROM OPERADORA WHERE OPERADORA = " + operadoraId;
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

        public int RemoverOperadora(int operadoraId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM OPERADORA WHERE ID = " + operadoraId;
                    connection.Execute(query);
                }

                return operadoraId;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
