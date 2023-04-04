using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SMT.Domain.Entities;
using SMT.Domain.Gateways;

namespace WebPortal.Controllers
{
    public class TecnicoController : Controller
    {
        private ITecnicoGateway _tecnicoGateway;

        public TecnicoController(ITecnicoGateway tecnicoGateway)
        {
            _tecnicoGateway = tecnicoGateway;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(IFormCollection form)
        {
            form.TryGetValue("CPF", out StringValues cpfValue);
            form.TryGetValue("Nome", out StringValues nomeValue);
            form.TryGetValue("CEP", out StringValues cepValue);
            form.TryGetValue("Logradouro", out StringValues logradouroValue);
            form.TryGetValue("Cidade", out StringValues cidadeValue);
            form.TryGetValue("Estado", out StringValues estadoValue);
            form.TryGetValue("Email", out StringValues emailValue);
            form.TryGetValue("Telefone", out StringValues telefoneValue);

            var endereco = new Endereco(cepValue, logradouroValue, cidadeValue, estadoValue);
            var contato = new Contato(emailValue, telefoneValue);
            var tecnico = new Tecnico(cpfValue, nomeValue, endereco, contato);

            _tecnicoGateway.Alterar(tecnico);

            return RedirectToAction("Index", "Home");
        }
    }
}
