using System.ComponentModel.DataAnnotations;

namespace WebPortal.Models
{
    public class Cada_TecnicoModel
    {
        public long ID { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required(ErrorMessage = "Digite o Nome do Técnico")]
        public string Nome { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [Required(ErrorMessage = "Por favor, preencher o campo CPF.")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }

        /// <summary>
        /// CEP
        /// </summary>
        [Required(ErrorMessage = "Digite o CEP")]
        [DataType(DataType.PostalCode)]
        public string CEP { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        [Required(ErrorMessage = "Digite o Endereço")]
        public string Logradouro { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        [Required(ErrorMessage = "Digite a Cidade")]
        public string Cidade { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [Required(ErrorMessage = "Digite o Estado")]
        [MaxLength(2)]
        public string Estado { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[2-9]\d{1}-\d{4}-\d{4}$", ErrorMessage = "Você deve digitar um telefone no formato ##-####-####")]
        public string Telefone { get; set; }
    }
}
