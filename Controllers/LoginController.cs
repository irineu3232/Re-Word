using Microsoft.AspNetCore.Mvc;
using Re_World.Models;
using Re_World.Repositorio;
using Org.BouncyCastle.Tls;



namespace New_Tech.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginRepositorio _loginRepositorio;

        public LoginController(LoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _loginRepositorio.ObterUsuario(email);
            if (usuario.Email != null && usuario.Senha !=null)
            {
                return RedirectToAction("Index", "Produto");
            }

            ModelState.AddModelError("", "Erro informações invalidas");
            return View();
        }
    }
}