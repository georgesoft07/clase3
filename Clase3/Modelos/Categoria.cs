using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Modelos
{
    public class Categoria:BaseEntity
    {
        public string Nombre { get; set; }

        public ICollection<Libro> Libros { get; set; }

        public Categoria() : base()
        {
            this.Libros = new HashSet<Libro>();
        }

    }
}
