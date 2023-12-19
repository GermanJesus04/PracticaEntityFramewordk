using PracticaLinq;

var queries = new LinqQueries();

//Lista de Libros
///ImprimirDatos(queries.TodaLaColeccion());

//Libros publicados despues del año 2000
///ImprimirDatos(queries.LibrosConUnaCondicionWhere());

//Libros que contengan mas de 250 pag y contengan la palabra "In Action"
///ImprimirDatos(queries.LibrosConDosCondicionWhere());

//todos los libros tiene status?
///Console.WriteLine($"todos los libros tiene status? - {queries.LibrosCondicionConAll()}");

//Alguno de los libros fue publicado en 2005?
///Console.WriteLine($"Alguno de los libros fue publicado en 2005? - {queries.LibrosCondicionConAny()}");

//Libros que sea de categoria python
///ImprimirDatos(queries.LibrosCondicionContains());

//Libros de java Ordenados por nombre
///ImprimirDatos(queries.LibrosJavaOrdenadosPorNombre());

//Libros con mas de 450 paginas ordenados por numero de paginas
ImprimirDatos(queries.LibrosOrdenadosPorPagDescendentes());

void ImprimirDatos(IEnumerable<Book> Listbooks)
{
    Console.WriteLine("{0,-70} {1,7} {2,11}\n", "Titulo","N. Paginas","Fecha Publicacion");

    foreach (var book in Listbooks)
    {
        //Console.WriteLine("{0,-70} {1,7} {2,11}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        Console.WriteLine(book.ToString());
    }
}
