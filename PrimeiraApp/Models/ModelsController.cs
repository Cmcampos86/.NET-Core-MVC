using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class ModelsController : Controller
    {
        public IActionResult Index()
        {
            //var aluno = new Aluno();
            var aluno = new Aluno()
            {
                Nome = "A",
                Email = "eduardo",
                EmailConfirmacao = "eduardo.com"
            };

            if (TryValidateModel(aluno))//Validação da Model
            {
                return View(aluno);
            }

            var ms = ModelState;//Retorna as validações da model

            //Retorna a lista de erros
            var erros = ModelState.Select(x => x.Value.Errors)
                                        .Where(y => y.Count > 0)
                                        .ToList();

            //Mostra a lista de erros
            erros.ForEach(r => Console.WriteLine(r.First().ErrorMessage));

            return View();
        }
    }
}