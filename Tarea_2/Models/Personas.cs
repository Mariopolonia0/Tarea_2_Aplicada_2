using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_2.BLL
{
    public class Personas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="No Ha Digitado El Nombre")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "No Ha Digitado El Telefono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "No Ha Digitado La Cedula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "No Ha Digitado La Dirrecion")]
        public string Dirrecion { get; set; }

        [Required(ErrorMessage = "No Ha Digitado Fecha de Naciminto")]
        public DateTime FechaNacimiento { get; set; }

        //telefono,cedula,dirrecion,fechanaciominto
    }
}
