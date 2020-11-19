using System;

namespace CodiceASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un valore numerico o alfanumerico da convertire in ASCII:");
            char carattere = Convert.ToChar(Console.ReadLine());
            int number = carattere;
            // aggiungere 4 al numero decimale corrispondente della lettera inserita
            // number = number + 4;
            Console.WriteLine($"Il carattere digitato corrisponde al numero: {number.ToString()}");
            Console.WriteLine(number.ToString());
            String binario = Convert.ToString(number, 2).PadLeft(8, '0');
            Console.WriteLine($"Il carattere in codice binario corrisponde alla sequenza di bit {binario}");
            Console.ReadLine();
        }
    }
}
