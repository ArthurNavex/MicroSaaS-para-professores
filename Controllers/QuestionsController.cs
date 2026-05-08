using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MicroSaaSProvas.Models;

namespace MicroSaaSProvas.Controllers;

public class QuestionsController: Controller
{
    static List<CreatQuestionsViewModel> listaQuestoes = new List<CreatQuestionsViewModel>();

    [HttpGet]
    public IActionResult CadastrarQuestoes() {
        return View();
    }

    [HttpGet]
    public IActionResult VerQuestoes() {
        return View(listaQuestoes);
    }

    [HttpPost]
    public IActionResult CadastrarQuestoes(CreatQuestionsViewModel dados) {
        if(!ModelState.IsValid) {
            return View(dados);
        }
        else{
            listaQuestoes.Add(dados);
            return RedirectToAction("VerQuestoes", "Questions");
        }
    }
}