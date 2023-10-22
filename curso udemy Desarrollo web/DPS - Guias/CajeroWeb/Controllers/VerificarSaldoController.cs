using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CajeroWeb.Models;

namespace CajeroWeb.Controllers
{
    public class VerificarSaldoController : Controller
    {
        // GET: VerificarSaldo
        public ActionResult VerificarSaldo(string sNumeroTarjeta, double sSaldo)
        {
            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo;
            return View();
        }
    }
}