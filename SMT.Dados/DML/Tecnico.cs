namespace SMT.Domain.Entities
{
    public class Tecnico
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// CEP
        /// </summary>
        public string CEP { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telefone { get; set; }
    }
}
