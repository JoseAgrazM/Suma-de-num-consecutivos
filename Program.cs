using System;

using System.Threading.Channels;



namespace Operadores

{
    class Program

    {
        static void Main(string[] args)

        {
            int isNumber;

            int isRep;

            bool esValido = false;

            while (!esValido)

            {

                Console.Clear();

                Console.WriteLine("Introduce un numero y dare los siguentes numeros que tu elijas y los sumare.");

                string inputNum = (Console.ReadLine());



                Console.WriteLine("Introduce el numero que quieres que saque los siguentes numeros al que has elegido antes.");

                string repNum = Console.ReadLine();



                if (int.TryParse(inputNum, out isNumber) && int.TryParse(repNum, out isRep))

                {

                    Console.Clear();

                    int suma = 0;

                    int i;

                    Console.WriteLine($"Tu numero es : {isNumber}");

                    suma += isNumber;


                    for (i = 0; i < isRep; i++)

                    {

                        isNumber++;

                        Console.WriteLine($"El {i + 1}º siguente numero es : {isNumber}");

                        suma += isNumber;

                    }

                    Console.WriteLine($"La suma de todos son : {suma}");

                    esValido = true;

                }

                else { Console.WriteLine("Introduce un numero valido"); }


                Console.WriteLine("Pulsa 'R' para repetir o cualquier otra tecla para salir.");


                char keyRep = Console.ReadKey().KeyChar;

                if (keyRep == 'R' || keyRep == 'r')

                {

                    esValido = false;

                }

            }

            Console.ReadKey();

        }

    }

}