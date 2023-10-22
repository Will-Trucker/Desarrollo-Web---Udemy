using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebMO232723.Models
{
    public class Datos
    {
        public List<Datos> DatosOfertas { get; set; }
        public String sNombreCategoria { get; set; }
        public String nIdOferta {  get; set; }
        public String sTituloOferta { get; set; }
        public String nTipoContrato { get; set; }
        public String nTipoJornada { get; set; }
        public String nTipoLocalidad { get; set; }
        public String fSalario { get; set; }
        public String dFechaPublicacion { get; set; }
        public String dFechaContratación { get; set; }
        public String sNombreEmpresa { get; set; }
        public String sNombreMunicipio { get; set; }
        public String nVacantes { get; set; }
        public String nIdLocalidad { get; set; }
        public String nIdCategoria { get; set; }
        public String nIdEmpresa { get; set; }
    }
}