using System;

namespace guia6Ejercicio3
{
    class Program
    {
        // Hacer un programa para recibir listas de numeros
        // positivos que estan separadas entre si por cero.
        // El fin de la carga se notifica con un numero negativo.
        // Luego mostrar cuantos numeros tiene cada lista.
        
        static void Main(string[] args)
        {
            int n, numGrupo = 0;

            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            while(n > 0){
                        
                int cont = 0;

                while(n != 0){
                    cont++;

                    Console.WriteLine("Ingrese otro nro:");
                    n = int.Parse(Console.ReadLine());
                }
                
                numGrupo++;

                Console.WriteLine("La lista " + numGrupo + " tiene: " + cont + " numeros.");
                Console.WriteLine("Ingrese un nro para una nueva lista: ");
                n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Fin del programa");
        }
    }
}
