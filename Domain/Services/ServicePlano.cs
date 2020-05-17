using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using Dapper;

using Domain.Repository;

namespace Domain.Services
{
    public class ServicePlano : IPlanoRepository
    {
        private string connectionString = "Data Source=DESKTOP-IQVN5PC\\SQLSERVER14;Initial Catalog=DESAFIO_WOOZA;Integrated Security=True;";

        public int AtualizarPlano(int planoId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "UPDATE PLANO SET (@CODIGO, @NOME, @DDD, @MINUTOS, @FRANQUIA, @VALOR, @TIPO, @DISPONIBILIDADE @ID_OPERADORA) WHERE CODIGO = " + planoId;
                    connection.Execute(query);
                }

                return planoId;
            }
            catch (Exception e)
            {
                throw e;
            }
        }                

        public void InserirPlano(Plano plano)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO PLANO VALUES(@CODIGO, @NOME, @DDD, @MINUTOS, @FRANQUIA, @VALOR, @TIPO, @DISPONIBILIDADE @ID_OPERADORA)";
                connection.Execute(query);
            }
        }        

        public Plano ObterPlano(int planoId, int planoDDD)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM PLANO WHERE CODIGO = " + planoId + " AND DDD = " + planoDDD + " WHERE DISPONIBILIDADE = 1";
                var plano = connection.Query<Plano>(query).FirstOrDefault();

                return plano;
            }
        }

        public Plano ObterPlanoPorTipo(int planoTipo, int planoDDD)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM PLANO WHERE TIPO = " + planoTipo + " AND DDD = " + planoDDD + " WHERE DISPONIBILIDADE = 1";
                var plano = connection.Query<Plano>(query).FirstOrDefault();

                return plano;
            }
        }

        public Plano ObterPlanoPorOperadora(int operadoraID, int planoDDD)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM PLANO WHERE ID_OPERADORA = " + operadoraID + " AND DDD = " + planoDDD + " WHERE DISPONIBILIDADE = 1";
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

        public int RemoverPlano(int planoId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM PLANO WHERE CODIGO = " + planoId;
                    connection.Execute(query);
                }

                return planoId;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
