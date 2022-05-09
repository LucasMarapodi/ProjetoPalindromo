using Microsoft.AspNetCore.Mvc;
using ProjetoPalindromo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPalindromo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PalavraModel teste = new PalavraModel();
            teste.PalavraInvertida = "";

            return View(teste);
        }
        
        [HttpPost]
        public IActionResult index(PalavraModel palavraModel)
        {
            if (ModelState.IsValid){

                try
                {
                    for (int i = palavraModel.Palavra.Length - 1; i >= 0; i--)
                    {
                        palavraModel.PalavraInvertida = palavraModel.PalavraInvertida + palavraModel.Palavra[i];
                    }

                    if (palavraModel.Palavra.ToLower() == palavraModel.PalavraInvertida.ToLower())
                    {
                        TempData["Mensagem"] = "É um palindromo!.";
                    }
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = "Erro : " + e.Message; 
                }

            }

            return View(palavraModel);
        }
    }
}
