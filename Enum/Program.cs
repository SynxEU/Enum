using System.Reflection;

namespace Enum
{
    class Program
    {
        static void Main()
        {
            Farver valgtFarve = Farver.Blå;

            UdskrivFarve(valgtFarve);
        }

        static void UdskrivFarve(Farver farve)
        {
            Console.WriteLine($"Valgt farve: {farve}");
        }
    }

}
