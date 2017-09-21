using ProgramacionEnBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotecaEFEntities db = new BibliotecaEFEntities();
            db.LongitudDeTituloEnLibros().ToList().ForEach(x=>Console.WriteLine(x.LongitudDelNombre));
            Console.ReadKey();
        }
    }
}
