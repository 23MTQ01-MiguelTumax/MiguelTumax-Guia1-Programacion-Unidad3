internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lección 16 - Actividad 2 -  Inciso 1");
        Console.WriteLine("Miguel Tumax / Clave 30");

        //Arreglo

        int[] edades = new int[7];
        int cantidadPersonasMayores = 0;


        //Soliciar las edades y almacenarlo en un arreglo
        for (int i = 0; i < edades.Length; i++)
        {
            Console.WriteLine("Ingrese la edad " + (i + 1) + ": ");
            edades[i] = Convert.ToInt32(Console.ReadLine());
            if (edades[i] >= 18)
            {
                cantidadPersonasMayores++;
            }
        }

        Console.Clear();

        //Mostrar los datos del arreglo
        Console.WriteLine("Las edades ingresadas son: ");
        for (int i = 0; i < edades.Length; i++)
        {
            Console.Write(edades[i] + " - ");
        }

        Console.WriteLine("La cantidad de personas mayores es: " + cantidadPersonasMayores);
    }
}