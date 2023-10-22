using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Guia6Ejercicio1
{
    internal class clsPersona
    {
        //CAMPOS
        //(protected: indica que seran visibles solo en interior de
        //los miembros de esta clase base y sus clases derivadas)
        protected string nombre;
        protected string foto; //URL de foto seleccionada para empleado
        protected DateTime fechanac;
        protected float sueldo;
        //METODOS

        public clsPersona()
        {
            nombre = "";
            foto = ""; //url de foto-empleado aun no asignada
            fechanac = Convert.ToDateTime("1900/01/01"); //fecha predeterminada
        }

        public virtual void asignarfechanac(string anno, string mes, string dia)
        {
         /*
         Este metodo debera ser reemplazado en clases derivadas, con otro metodo
         que tenga el mismo encabezado (lista de parametros o firma)
         */
         fechanac = Convert.ToDateTime(anno + "/" + mes + "/" + dia);
         MessageBox.Show("de clase Persona");
        }

        //PROPIEDADES

        public string nombreempleado
        {
            //accede a propiedad: nombre
            get
            {
                return (nombre);
            }
            set
            {
                if (value.Length > 1)
                    nombre = value;
                else
                    nombre = "";
            }
        }

        public string URLfoto
        {
            get
            {
                return (foto); //retorna la URL de donde se selecciono foto
            }
            set
            { //recibe la url de la imagen seleccionada por usuario
                if (nombre == "")
                {
                    MessageBox.Show("usuario no tiene aun nombre asignado");
                }
                else
                {
                    //genera la URL del nuevo archivo JPG, que se copiara hacia carpeta de esta aplicacion
                    foto = Application.StartupPath + "\\" + nombre + ".jpg";
                    //Copia archivo de ubic. elegida por usuario hacia ruta del ejecutable del proyecto actual
                    File.Copy(value, foto, true);
                }
            }
        }

        public float sueldobase
        {

            //acceso lectura-escritura hacia campo sueldo
            get
            {
                return (sueldo);
            }
            set
            {
                if (value > 0)
                    sueldo = value;
                else
                    MessageBox.Show("Valor de sueldo incorrecto", "ERROR-SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public string fecha_nacimiento
        {
            //propiedad solo-lectura
            get
            {
                return (fechanac.ToShortDateString().ToString());
            }
        }
    }

    class clsDoctor : clsPersona
    {
        //campo privado: solo accesibles en interior de esta clase
        string cod_doctor;
        //Propiedades
        public string codigodoctor
        {
            get
            {
                return (cod_doctor);
            }
            set
            {
                cod_doctor = value;
            }
        }
    

    //Metodos

    public clsDoctor()
    { //metodo constructor
        nombre = "";
        sueldo = 5;
        fechanac = Convert.ToDateTime("1900/1/1");
    }

    //Este metodo en la clase Hija es el reemplazo exigido por la clase Base
    //->Observe que tiene el mismo nombre y FIRMA (lista/tipo de parametros) del metodo original
    public override void asignarfechanac(string anno, string mes, string dia)
    {
        TimeSpan diftiempo; //almacena un rango de tiempo entre 2 fechas
        try//detecta si la fecha no tiene el formato esperado
        {
            DateTime fnac = Convert.ToDateTime(anno + "/" + mes + "/" + dia);
            //calcula diferencia de tiempo entre fecha de nac. recibida y la fecha actual
            diftiempo = fnac - DateTime.Now;
            //determina si fecha ingresada es al menos 18 años antes de la fecha actual
            if (diftiempo.TotalDays < -365 * 18)
                fechanac = fnac; //acepta fecha recibida en parametros
            else
                MessageBox.Show("Fecha nacimiento debe ser al menos 18 años antes de hoy", "ERROR-Sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (FormatException)
        {
            MessageBox.Show("Fecha brindada es incorrecta", "ERROR-SISTEMA!!", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
      }
        //Sobrecarga de metodo:
        public void asignarfechanac(string fecha)
        {
            DateTime fechafin;
            //Funcion intenta convertir cadena fecha a tipo DateTime en fechafin.
            //Si es correcto, devuelve true
            if (DateTime.TryParse(fecha, out fechafin))
            {
                fechanac = fechafin;
            }
            else
                MessageBox.Show("Fecha de nacimiento es recibida", "ERROR DE SISTEMA!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        //Confirma si datos para agregar un Doctor son correctos
        public bool DatossonCorrectos()
        {
          if (nombre != "")
          if (sueldo > 0)
          if (fechanac != Convert.ToDateTime("1900/01/01"))
          return (true); //Los datos recibidos son correctos
          else
          MessageBox.Show("aun no se ha asignado fecha de nacimiento");
          else
          MessageBox.Show("Sueldo incorrecto");
          else
          MessageBox.Show("Nombre aun no asignado");
          return (false);
        }
    }

    class clsVendedor : clsPersona
    {
        //Campos (propios de clase derivada)
        DateTime fechacontratac;


        //Metodos 
        public clsVendedor()
        {
            fechanac = Convert.ToDateTime("1950/01/01");
            fechacontratac = Convert.ToDateTime("2000/01/01");
        }

        ////Este metodo en la clase Hija reemplaza al metodo de la clase Base
        //->Observe que tiene el mismo nombre, pero diferente firma (lista de parametros)
        public void asignarfechanac(DateTime fechanacimiento) 
        {
            fechanac = fechanacimiento;
        }

        //PROPIEDADES
        public DateTime FechaContrato
        {
            get
            {
                return (fechacontratac);
            }
            set
            {
                this.fechacontratac = value;
            }
        }
    }


}
    




