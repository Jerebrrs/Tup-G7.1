namespace Ejercisio2
{
    public class Budines
    {
        public Budines()
        {
            Console.WriteLine("---------Ejercicio 2 : Budines -----------------");

            double masaProducida, moldeMasa = 0.55, masaSobrante;
            int totalDeBudines, paqueteBudines = 12, cajaDeBudines = 20, totalDecajas, totalDePaquetes, budinesSobrantes, paquetesSobrantes;
            Console.WriteLine("Ingrese la cantidad de masa producida en kilos: ");
            masaProducida = Convert.ToDouble(Console.ReadLine());

            totalDeBudines = (int)(masaProducida / moldeMasa);
            masaSobrante = masaProducida - (totalDeBudines * moldeMasa);
            totalDePaquetes = totalDeBudines / paqueteBudines;
            budinesSobrantes = totalDeBudines % paqueteBudines;
            totalDecajas = totalDePaquetes / cajaDeBudines;
            paquetesSobrantes = totalDecajas % cajaDeBudines;

            Console.WriteLine("-------------------");
            Console.WriteLine($"La cantidad de masa producida es de {masaProducida} kilos, lo cual alcanza para {totalDeBudines} budines.");
            Console.WriteLine($"La cantidad de masa sobrante es de {masaSobrante:f2} gr.");
            Console.WriteLine($"Se podran armar {totalDePaquetes} paquetes de 12 budines.");
            Console.WriteLine($"Sobran sin empaquetar {budinesSobrantes} budines.");
            Console.WriteLine($"Se podran armar la cantidad {totalDecajas} de cajas de budines");
            Console.WriteLine($"Sobrando la cantidad de {paquetesSobrantes}.");
        }
    }
}   