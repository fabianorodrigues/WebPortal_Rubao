using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SMT.Domain.Entities;
using SMT.Domain.Gateways;
using System;

namespace AspCore_WebCam.Controllers
{
    public class CameraController : Controller
    {
        private ITecnicoGateway _tecnicoGateway;

        public CameraController(ITecnicoGateway tecnicoGateway)
        {
            _tecnicoGateway = tecnicoGateway;
        }

        public IActionResult CapturaImagem(IFormCollection form)
        {
            var endereco = new Endereco(string.Empty, string.Empty, string.Empty, string.Empty);
            var contato = new Contato(string.Empty, string.Empty);

            form.TryGetValue("CPF", out StringValues cpfValue);
            form.TryGetValue("Nome", out StringValues nomeValue);

            var tecnico = new Tecnico(cpfValue.ToString(), nomeValue.ToString(), endereco, contato);

            tecnico.SetImagem(form.Files);

            if (tecnico.Valid)
            {
                _tecnicoGateway.Incluir(tecnico);
            }

            return Ok();
        }
    }
}