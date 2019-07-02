using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method

            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Muestra paginas del documento

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Espera al usuario

            Console.ReadKey();
        }
    }
}
