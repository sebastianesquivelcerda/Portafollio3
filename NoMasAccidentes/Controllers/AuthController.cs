using NoMasAccidentesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;

namespace NoMasAccidentes.Controllers
{
    public class AuthController : Controller
    {
       public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario usuario,string ReturnUrl)
        {
            if (IsValid(usuario))
            {
                FormsAuthentication.SetAuthCookie(usuario.Email, false);
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
            }
            TempData["mensaje"] = "Credenciales Incorrecta";
            return View(usuario);
        }
        private bool IsValid(Usuario usuario)
        {


            return usuario.Autenticar();

         //if (usuario.Email == "admin@admin.cl" && usuario.Password == "admin")

         // {
         //     return true;
         // }
         //  return false;
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
