using Dapper;
using Microsoft.Extensions.Configuration;
using SMT.Domain.Entities;
using SMT.Domain.Gateways;
using SMT.Domain.Queries;
using System.Data.SqlClient;
using System.Linq;

namespace SMT.Infra.Repositories
{
    public sealed class TecnicoRepository : ITecnicoGateway
    {
        private readonly IConfiguration _configuration;

        public TecnicoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }

        public void Incluir(Tecnico tecnico)
        {
            var tecnicoQuery = new TecnicoQuery(tecnico);

            using (var con = new SqlConnection(GetConnectionString()))
            {
                con.Execute(@"INSERT INTO Tecnico (CPF, Nome, CEP, Logradouro, Cidade, Estado, Email, Telefone, Imagem) 
                                VALUES (@CPF, @Nome, @CEP, @Logradouro, @Cidade, @Estado, @Email, @Telefone, @Imagem)",
                        new
                        {
                            CPF = tecnicoQuery.CPF,
                            Nome = tecnicoQuery.Nome,
                            CEP = tecnicoQuery.CEP,
                            Logradouro = tecnicoQuery.Logradouro,
                            Cidade = tecnicoQuery.Cidade,
                            Estado = tecnicoQuery.Estado,
                            Email = tecnicoQuery.Email,
                            Telefone = tecnicoQuery.Telefone,
                            Imagem = tecnicoQuery.Imagem
                        });
            }
        }

        public TecnicoQuery Consultar(string cpf)
        {
            using (var con = new SqlConnection(GetConnectionString()))
            {
                var query = $"SELECT CPF, Nome, CEP, Logradouro, Cidade, Estado, Email, Telefone, Imagem FROM Tecnico WHERE CPF = {cpf}";
                return con.Query<TecnicoQuery>(query).FirstOrDefault();
            }
        }

        public void Alterar(Tecnico tecnico)
        {
            var tecnicoQuery = new TecnicoQuery(tecnico);

            using (var con = new SqlConnection(GetConnectionString()))
            {
                con.Execute(@"UPDATE Tecnico SET 
                            CPF = @CPF, Nome = @Nome, CEP = @CEP, Logradouro = @Logradouro, Cidade = @Cidade, Estado = @Estado, Email = @Email, Telefone = @Telefone",
                        new
                        {
                            CPF = tecnicoQuery.CPF,
                            Nome = tecnicoQuery.Nome,
                            CEP = tecnicoQuery.CEP,
                            Logradouro = tecnicoQuery.Logradouro,
                            Cidade = tecnicoQuery.Cidade,
                            Estado = tecnicoQuery.Estado,
                            Email = tecnicoQuery.Email,
                            Telefone = tecnicoQuery.Telefone,
                        });
            }
        }
    }
}
