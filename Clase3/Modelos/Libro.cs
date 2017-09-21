using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Modelos
{
    public class Libro : BaseEntity
    {
        public string Nombre { get; set; }
        public int Edicion { get; set; }
        public string Genero { get; set; }

        [ForeignKey("Autor")]
        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }

        public ICollection<Categoria> Categorias { get; set; }

        public Libro() : base()
        {
            this.Categorias = new HashSet<Categoria>();
        }

    }
}
