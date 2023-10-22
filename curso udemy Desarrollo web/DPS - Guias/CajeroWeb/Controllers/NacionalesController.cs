using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using CajeroWeb.Models;

namespace CajeroWeb.Controllers
{
    public class NacionalesController : Controller
    {
        // GET: Nacionales
        public ActionResult Nacionales(string sNumeroTarjeta, double sSaldo)
        {
            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo;
            return View();
        }
        [HttpPost]
        public ActionResult Nacionales(string sNumeroTarjeta, double sSaldo, double cantidad)
        {
            double Saldo;
            //Se crea una instancia de la clase transacción y se le envían dos parámetros
            transaccion nuevaTransaccion = new transaccion(sNumeroTarjeta, sSaldo);
            if (cantidad > 0 && sSaldo >= cantidad)
            {
                // Realizar la transacción de depósito nacional solo si hay saldo suficiente
                nuevaTransaccion.transferenciaNacional(cantidad);

                // Obtener el saldo actualizado después de la transacción
                double saldoActualizado = nuevaTransaccion.getSaldo();
                sSaldo = nuevaTransaccion.getSaldo();
                ViewBag.sNumeroTarjeta = nuevaTransaccion.getNumTarjeta();
                ViewBag.sSaldo = saldoActualizado;

                // Redirigir a la acción de verificación de saldo
                return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" + sSaldo);
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada si no hay saldo suficiente
                ViewBag.Error = "Saldo insuficiente para realizar la transacción.";
                return View("Nacionales"); // Puedes redirigir nuevamente a la vista "Nacionales"
            }
          
           
        }
    }
}
