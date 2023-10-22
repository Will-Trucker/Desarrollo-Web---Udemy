using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebMO232723.Models
{
    public class Localidad
    {
        public List<SelectListItem> Localidades { get; set; }

        public int idMunicipio;
        public string sNombreMunicipio;
        public int nIdPais;
    }
}