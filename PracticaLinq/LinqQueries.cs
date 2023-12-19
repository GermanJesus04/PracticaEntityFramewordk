using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq
{
    public class LinqQueries
    {
        private List<Book> Listbooks = new List<Book>();
        
        
        public LinqQueries()
        {
            //captura nombre del proyecto
            string nombreApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

            //busca y carga el archivo embebido  
            Stream resourceStream = this.GetType().Assembly.GetManifestResourceStream($"{nombreApp}.books.json");

            using (var reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                
                string json = reader.ReadToEnd();

                //desearializar de json a lista de objeto book
                Listbooks = JsonConvert.DeserializeObject<List<Book>>(json);
            }

        }

        public IEnumerable<Book> TodaLaColeccion()
        {
            return Listbooks;
        }

        public IEnumerable<Book> LibrosConUnaCondicionWhere()
        {
            //Metodo extenciones
            return Listbooks.Where(p => p.PublishedDate.Year > 2000);

            //Metodo con query
            return  from book in Listbooks
                    where book.PublishedDate.Year > 2000
                    select book;
        }

        public IEnumerable<Book> LibrosConDosCondicionWhere()
        {
            ///Metodo extenciones
            return Listbooks.Where(p =>  p.PageCount > 250 &&
                                       p.Title.Contains("in Action"));
            

            ///Metodo con query
            return from book in Listbooks
                   where book.PageCount > 250 &&
                         book.Title.Contains("in Action")
                   select book;
        }

        public bool LibrosCondicionConAll()
        {
            ///Metodo extenciones
            return Listbooks.All(x=> !string.IsNullOrEmpty(x.Status));
              
        }
        public bool LibrosCondicionConAny()
        {
            ///Metodo extenciones
            return Listbooks.Any(x =>x.PublishedDate.Year == 2005);

        }

        public IEnumerable<Book> LibrosCondicionContains()
        {
            ///Metodo extenciones
            return Listbooks.Where(x => x.Categories.Contains("Python"));

            ///Metodo query
            return from book in Listbooks
                   where book.Categories.Contains("Python")
                   select book;
            
        }

        public IEnumerable<Book> LibrosJavaOrdenadosPorNombre()
        {
            ///Metodo extenciones
            return Listbooks.Where(cat => cat.Categories.Contains("Java")).OrderBy(x=>x.Title);


            ///Metodo query
            return from book in Listbooks
                   where book.Categories.Contains("Java")
                   orderby book.Title
                   select book;
        }

        public IEnumerable<Book> LibrosOrdenadosPorPagDescendentes()
        {
            ///Metodo extenciones
            return Listbooks.Where(x=> x.PageCount > 450).OrderByDescending(x => x.PageCount);


            ///Metodo query 
        }

    }
}
