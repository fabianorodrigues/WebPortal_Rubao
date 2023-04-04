using SMT.Domain.Entities;

namespace SMT.Domain.Queries
{
    public sealed class TecnicoQuery
    {
        public TecnicoQuery()
        {

        }

        public TecnicoQuery(Tecnico tecnico)
        {
            CPF = tecnico.CPF;
            Nome = tecnico.Nome;
            CEP = tecnico.Endereco?.CEP;
            Logradouro = tecnico.Endereco?.Logradouro;
            Cidade = tecnico.Endereco?.Cidade;
            Estado = tecnico.Endereco?.Estado;
            Email = tecnico.Contato?.Email;
            Telefone = tecnico.Contato?.Telefone;
            Imagem = tecnico.Imagem;
        }

        public string CPF { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public byte[] Imagem { get; set; }
    }
}
