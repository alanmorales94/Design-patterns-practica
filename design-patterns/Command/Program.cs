using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea un usuario y deja que compute

            User user = new User();

            // El usuario presiona botones de calculadora

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Deshace 4 comandos

            user.Undo(4);

            // Vuelve a hacer 3 comandos

            user.Redo(3);

            // Espera al usuarioo

            Console.ReadKey();
        }
    }
}
