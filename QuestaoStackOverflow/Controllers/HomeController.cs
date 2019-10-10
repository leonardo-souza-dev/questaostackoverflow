using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestaoStackOverflow.Models;

namespace QuestaoStackOverflow.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var c1 = new Contrato { Id = 1, Cliente = new Cliente { Nome = "Foo1" }, PedidoVenda = new PedidoVenda { EmpresaID = 1 }, Valor = 11.11M, Checado = false };
            var c2 = new Contrato { Id = 2, Cliente = new Cliente { Nome = "Foo2" }, PedidoVenda = new PedidoVenda { EmpresaID = 2 }, Valor = 22.22M, Checado = false };
            var c3 = new Contrato { Id = 3, Cliente = new Cliente { Nome = "Foo3" }, PedidoVenda = new PedidoVenda { EmpresaID = 3 }, Valor = 33.33M, Checado = true };

            var listaContrato = new ListaContrato();
            listaContrato.Id = 14;
            listaContrato.Contratos.Add(c1);
            listaContrato.Contratos.Add(c2);
            listaContrato.Contratos.Add(c3);

            return View(listaContrato);
        }

        [HttpPost]
        [Route("/Home/Enviar")]
        public async Task<IActionResult> Enviar(EnviarLoteViewModel enviarLoteViewModel)
        {
            return View("Index");
        }
    }
}
