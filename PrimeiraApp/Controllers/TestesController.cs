﻿using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApp.Controllers
{
    //Pode colocar mais de uma rota
    [Route("/", Order = 0)] //A ordem da rota é barra. Quando carrega a plaiucação já vai aqui.
    [Route("minha-conta", Order = 1)]
    [Route("gestao-da-conta", Order = 2)]//Pode colocar uma ordem de chamada das rotas
    public class TestesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("detalhes/{id:int}")] //Especificar os verbos
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
