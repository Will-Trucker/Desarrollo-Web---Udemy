using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CajeroWeb.Models
{
    public class transaccion
    {
        // Clase que se utiliza para gestionar las transacciones a realizar por el cajero ATM
        //Campos (privados) de la clase
        private String sNumeroTarjeta;
        private double fSaldo;
        //Constructor de clase que solo acepta un parametro de tipo String
        public transaccion(String tarjeta)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = 500;
        }

        //Constructor de clase que acepta dos parametros: String y double.
        //Puede haber tantos constructores como se necesiten, pero c/definición debe tener
        // una firma (lista y orden de tipos de datos en parametros) diferente.
        public transaccion(String tarjeta, double saldo)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = saldo;
        }

        //Implementa métodos (get y set) para acceder a campos de clase
        public double getSaldo()
        {
            return fSaldo;
        }
        public void setSaldo(double saldo)
        {
            fSaldo = saldo;
        }
        public String getNumTarjeta()
        {
            return sNumeroTarjeta;
        }
        public void setNumTarjeta(String tarjeta)
        {
            sNumeroTarjeta = tarjeta;
        }
        public void transferenciaNacional(double monto)
        {
            fSaldo = fSaldo - monto;
        }
        public void transferenciaInternacional(double monto)
        {
            fSaldo = fSaldo - monto;
        }

        public void transferenciaServicios(double monto)
        {
            fSaldo = fSaldo - monto;
        }
    }
}