using System;
using Bilgi_Sistemleri.Helpers;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "abcd ABCD 1234567890CCC           ";
            var newText = Encoder.Encipher(text, Constants.Key);
            var decodedText = Encoder.Decipher(newText, Constants.Key);
            Console.WriteLine(newText);
            Console.WriteLine(decodedText);
        }
    }
}
