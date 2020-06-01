using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
           //4. Un programa que lea numeros de la entrada estandar e imprima su promedio (media aritmetica) 	
           //El "fin" es la lectura de una linea en blanco / nula

           int numero = 0;
            int acum = 0;
            int counter = 0;
            bool success;

            do
            {
                success = int.TryParse(Console.ReadLine(), out numero);

                if(success){
                    acum += numero;
                    counter++;
                }           

            } while (success != false);

            Console.WriteLine(acum/counter);

        }
    }
}
