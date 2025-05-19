namespace Ejercisio3
{
    public class Patentes
    {
        public Patentes()
        {
            Console.WriteLine("---------Ejercicio 3 :Patentes -----------------");

            Console.WriteLine("Ingrese un numero para su patente: ");
            int numeroPatente = Convert.ToInt32(Console.ReadLine());

            int baja = numeroPatente % 1000;
            int alta = numeroPatente / 1000;
            alta = alta % (26 * 26 * 26);

            char d1 = Convert.ToChar(alta / (26 * 26) + 65);
            char d2 = Convert.ToChar(alta % (26 * 26) / 26 + 65);
            char d3 = Convert.ToChar(alta % (26 * 26) % 26 + 65);
           string numeros = baja.ToString("D3");

            string patente = $"{d1}{d2}{d3}{numeros}";

            Console.WriteLine($"Para el número {numeroPatente}, la patente conformada es: {patente}");
        }
    }
}