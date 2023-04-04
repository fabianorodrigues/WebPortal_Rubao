namespace SMT.Domain.Entities
{
    public sealed class Endereco
    {
        public Endereco(string cEP, string logradouro, string cidade, string estado)
        {
            CEP = cEP;
            Logradouro = logradouro;
            Cidade = cidade;
            Estado = estado;
        }

        /// <summary>
        /// CEP
        /// </summary>
        public string CEP { get; }

        /// <summary>
        /// Logradouro
        /// </summary>
        public string Logradouro { get; }

        /// <summary>
        /// Cidade
        /// </summary>
        public string Cidade { get; }

        /// <summary>
        /// Estado
        /// </summary>
        public string Estado { get; }
    }
}
