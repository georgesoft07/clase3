using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase3.Contextos;
using Clase3.Modelos;

namespace ConsolaDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblitoteca = new Biblioteca();
            Autor autor = new Autor();
            autor.Nacionalidad = "Peruana";
            autor.FechaNacimiento = DateTime.Now;
            autor.Nombre = "Daniel";
            autor.edad = "25";
            autor.peso = "70";
            Libro nuevoLibro = new Libro();
            nuevoLibro.Edicion = 3;
            nuevoLibro.Genero = "Terror";
            nuevoLibro.Nombre = "Perros Hambrientos";
            autor.Libros.Add(nuevoLibro);
            Categoria categoria1 = new Categoria();
            categoria1.Nombre = "Terror";
            nuevoLibro.Categorias.Add(categoria1);
            biblitoteca.Autores.Add(autor);
            biblitoteca.SaveChanges();
        }
    }
}
