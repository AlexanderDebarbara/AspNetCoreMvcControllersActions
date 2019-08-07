using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvcControllersActions.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class PessoaController : Controller
    {
        public ViewResult Index()
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "alexander";
            pessoa.Telefone = "65 92036920";
            return View("Pessoa", pessoa);
        }
        public ViewResult Formulario()
        { 
            return View();
        }
        [HttpPost]
        public ViewResult Formulario(Pessoa pessoa)
        { 
            return View("DetalhesPessoa", pessoa);
        }

    }
}