namespace SMT.Domain.Entities
{
    public sealed class Contato
    {
        public Contato(string email, string telefone)
        {
            Email = email;
            Telefone = telefone;
        }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telefone { get; }
    }
}
