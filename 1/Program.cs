using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Programa que recibe un parametro por la consola (argumento de linea de comando)	
            //El parametro es numerico, entero y positivo 
            //Debe imprimir los numeros del 1 hasta el numero introducido uno por linea
            //Si el valor introducido es invalido (cero, negativo o no puede ser convertido a numero), 
            //debe escribir un error por la salida de error estandard

            int numero = 0;
            int i = 1;

            if(int.TryParse(args[0], out numero) && numero > 0){
                for (; i <= numero; i++)
                {
                    Console.WriteLine(i);
                }

            }else{
                Console.Error.WriteLine("El valor introducido es invalido (cero, negativo o no puede ser convertido a numero) ({0})", args[0]);
            }


        }
    }
}
