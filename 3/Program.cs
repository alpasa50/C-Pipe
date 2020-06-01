using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            //3. Un programa que lea numeros de la entrada estandard e imprima su cuadrado (n x n) 	
            //El "fin" es la lectura de una linea en blanco / nula 
            int numero = 0;
            int acum = 0;
            bool success;

            do
            {
                success = int.TryParse(Console.ReadLine(), out numero);

                if(success){
                    acum = numero * numero;
                    Console.WriteLine(acum);
                }

                
                
            } while (success != false);

            
        }
    }
}
