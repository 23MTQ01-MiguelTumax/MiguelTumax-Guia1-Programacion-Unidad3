using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numerosEnteros = new int[15];

        int indice, comparador;
        bool existeRepetido;

        existeRepetido = false;

        for (indice = 0; indice < numerosEnteros.Length; indice++)
        {
            Console.WriteLine("Ingrese el número " + (indice + 1) + ": ");
            numerosEnteros[indice] = Convert.ToInt32(Console.ReadLine());
        }

        for (indice = 0; indice < 14; indice++)
        {
            for (comparador = indice + 1; comparador < 14; comparador++)
            {
                if (numerosEnteros[indice] == numerosEnteros[comparador])
                {
                    existeRepetido = true;
                }
            }
        }

        if (existeRepetido == true)
        {
            Console.WriteLine("Si existe al menos un número repetido");
        }
        else
        {
            Console.WriteLine("No existe ningún número repetido");
        }
    }
}