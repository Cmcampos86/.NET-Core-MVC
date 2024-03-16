using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApp.Controllers
{
    //Pode colocar mais de uma rota
    [Route("/", Order = 0)] //A ordem da rota é barra. Quando carrega a plaiucação já vai aqui.
    [Route("minha-conta", Order = 1)]
    [Route("gestao-da-conta", Order = 2)]//Pode colocar uma ordem de chamada das rotas
    public class TestesController : Controller
    {
        //Especificar os verbos
        //Deve manter o nome do parâmetro que esta na rota.
        //Pode alterar o nome ou na configuração da rota ou no parâmetro do verbo que esta a rota
        //Caso seja passado mais um parâmetro na controller, este pode ser acesso como se fosse uma querystring (Ex: detalhes/1?teste=ola).
        //O parâmetro passa a ser uma rota e não um parâmetro
        //Exemplo de parâmetro opcional: [HttpGet("detalhes/{id:int}/{id2?}")] e na controller Details(int id, int id2 = 0) - Opcional
        //Quando o verbo é post:
            //Usando o Bind para especificar o campos do Form que eu quero: Create([Bind("Id,Nome,Email")] IFormCollection collection)
            //Usando o FromForm vai pegar todas as informações do formulário: Create([FromForm] IFormCollection collection)

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("detalhes/{id:int}")] 
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet("novo")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("novo")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost("editar/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost("excluir/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
