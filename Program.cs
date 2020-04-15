using System;

namespace Prac_7_Eje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, num, a ,s ;
            string tex, rev = ""; 
            Console.WriteLine("BIENVENIDO AL PROGRAMA");
            Console.Write("INGRESE UN NÚMERO DE CINCO CIFRAS...");
            tex = Console.ReadLine();
            char[] c = tex.ToCharArray();
            // MIENTRAS QUE J NO SEA MENOR QUE -1 LE VOY RESTANDO DE 1 EN 1
            //J VA A SER LA POSICION Y VA DE ATRAS PARA ADELANTE 
            for (j = c.Length - 1; j > -1; j--)
            {
                //VOY LLENADO LA VARIABLE CON LOS VALORES INVERTIDOS 
                rev += c[j];
            }
            Console.WriteLine("EL NÚMERO INVERTIDO ES: {0}", rev);
            // OPERO PARA COMPROVAR SI ES PRIMO
            num = Convert.ToInt32(rev);
            a = 0;
            for (s = 1; s < (num + 1); s++)
            {
                if (num % s == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("EL NÚMERO " + num + " NO ES PRIMO");
            }
            else
            {
                Console.WriteLine("EL NÚMERO " + num + " Si ES PRIMO");
            }
            Console.WriteLine("GRACIAS POR USAR EL PROGRAMA");
            Console.WriteLine("PRESIONE TECLA PARA SALIR");
            Console.ReadKey();
        }
    }
}
