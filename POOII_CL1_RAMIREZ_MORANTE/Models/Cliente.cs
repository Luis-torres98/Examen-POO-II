using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POOII_CL1_RAMIREZ_MORANTE.Controllers
{
    public class Cliente
    {
        [DisplayName("CODIGO")]
        [Required(ErrorMessage = "Ingrese codigo")]

        public string Codigo { get; set; }

        [DisplayName("NOMBRES")]
        [Required(ErrorMessage ="Ingrese el nombre")]
        public string Nombres { get; set; }

        [DisplayName("TELEFONOS")]
        [Required(ErrorMessage = "Ingrese el telefono")]
        public string Telefonos { get; set; }

        [DisplayName("TIPO DE CLIENTE")]
        [Required(ErrorMessage = "Ingrese el tipo de cliente")]
        public string TipoCliente { get; set; }

        [DisplayName("CORREO ELETRÓNICO")]
        [EmailAddress]

        [Required(ErrorMessage = "Ingrese el correo")]
        public string correo { get; set; }



    }
}