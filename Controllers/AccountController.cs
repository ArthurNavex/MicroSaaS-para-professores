using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MicroSaaSProvas.Models;

namespace MicroSaaSProvas.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    static LoginViewModel login = new LoginViewModel();

    [HttpPost]
    public IActionResult Login(LoginViewModel dados) {

        if(!ModelState.IsValid) {
            return View(dados);
        }

        if(dados.Username == login.Username && dados.Password == login.Password) {
            return RedirectToAction("Index", "Home");
        }
        else {
            ViewBag.ErrorMessage = "Usuario ou senha inválidos";
            return View();
        }
    }

        [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(RegisterViewModel dados) {
        if(!ModelState.IsValid) {
            return View(dados);
        }
        else {
            login.Username = dados.Username;
            login.Password = dados.Password;
            return RedirectToAction("Login", "Account");
        }
    }
}