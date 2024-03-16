using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.ViewComponents
{
    //ViewComponents: Componentes independentes. São server-side e podem realizar ações como obter dados de uma tabela e exibir valores manipulados.
    //Os ViewComponents podem serv recursos como carrinho de compras, paginação, barra de pesquisa e etc
    //ViewComponents segue uma convenção: <Nome>ViewComponent e herda de ViewComponent
    //Criar uma pasta dentro de Shared como Components

    public class SaudacaoAlunoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Pegar o aluno lá na base de dados!!!
            // Pegar o dado (nome) do aluno que está logado!
            var aluno = new Aluno() { Nome = "Eduardo" };

            return View(aluno);
        }
    }
}
