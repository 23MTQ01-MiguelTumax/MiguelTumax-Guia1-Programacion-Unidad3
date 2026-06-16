internal class Program
{
    private static void Main(string[] args)
    {
        int indice, numeroMayor, posicionMayor;
        numeroMayor = 0;
        posicionMayor = 0;

        int[] numerosEnteros = new int[8];

        for (indice = 0; indice < numerosEnteros.Length; indice++)
        {
            Console.WriteLine("Ingrese el número " + (indice + 1) + ": ");
            numerosEnteros[indice] = Convert.ToInt32(Console.ReadLine());

            if (indice == 1)
            {
                numeroMayor = numerosEnteros[indice];
                posicionMayor = indice;
            }
            else if (numerosEnteros[indice] > numeroMayor)
            {
                numeroMayor = numerosEnteros[indice];
                posicionMayor = indice;
            }
        }

        Console.WriteLine("El número mayor es: " + numeroMayor);
        Console.WriteLine("Se encuentra en la posición: " + (posicionMayor + 1));
    }
}