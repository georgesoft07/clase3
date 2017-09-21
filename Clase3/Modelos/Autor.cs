using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Modelos
{
    public class Autor:BaseEntity
    {
        [Required]
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string edad { get; set; }
        public string peso { get; set; }


        public ICollection<Libro> Libros { get; set; }

        public Autor():base() {
            this.Libros = new HashSet<Libro>();
        }
    }
}
