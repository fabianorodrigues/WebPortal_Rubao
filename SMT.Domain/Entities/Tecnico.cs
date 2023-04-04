using FluentValidator;
using System.IO;
using System;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace SMT.Domain.Entities
{
    public class Tecnico : Notifiable
    {
        public Tecnico(string cPF, string nome, Endereco endereco, Contato contato)
        {
            CPF = cPF;
            Nome = nome;
            Endereco = endereco;
            Contato = contato;

            Validar();
        }

        /// <summary>
        /// CPF
        /// </summary>
        public string CPF { get; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; }

        public byte[] Imagem { get; private set; }

        public Endereco Endereco { get; }

        public Contato Contato { get; }

        public void SetImagem(IFormFileCollection fileCollection)
        {
            if (fileCollection.Count > 0)
            {
                using (var ms = new MemoryStream())
                {
                    var file = fileCollection.FirstOrDefault();

                    if (file != null)
                    {
                        file.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        Imagem = fileBytes;
                    }
                }
            }
        }

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AddNotification(nameof(Nome), "Nome do técnico inválido.");

            if (string.IsNullOrWhiteSpace(CPF) || CPF.Length < 11)
                AddNotification(nameof(CPF), "CPF do técnico inválido.");
        }

    }
}
