using System.Data;

namespace Guia7
{
    public class Niñas
    {
        public Niñas()
        {
            int n1, n2, n3, sumaEdades, n4;
            double mensualidad, promedio1, promedio2, promedio3, promedio4;

            Console.WriteLine("Ingrese la mensualidad a repartir entre las niñas: ");

            mensualidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las edades de las 3 niñas por favor");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());

            sumaEdades = n1 + n2 + n3 + n4;

            promedio1 = (double)n1 / sumaEdades;
            promedio2 = (double)n2 / sumaEdades;
            promedio3 = (double)n3 / sumaEdades;
            promedio4 = (double)n4 / sumaEdades;

            Console.WriteLine(promedio1);
            Console.WriteLine("------------------------------->");
            Console.WriteLine($"La mensualidad que se dividira entre las niñas es de ${mensualidad}");
            Console.WriteLine($"La mensualidad de la niña de {n1} años es de ${mensualidad * promedio1:f2}");
            Console.WriteLine($"La mensualidad de la niña de {n2} años es de de ${mensualidad * promedio2:f2}");
            Console.WriteLine($"La mensualidad de la niña de {n3} años es de ${mensualidad * promedio3:f2}");
            Console.WriteLine($"La mensualidad de la niña de {n4} años es de ${mensualidad * promedio4:f2}");
        }
    }
    
    
}