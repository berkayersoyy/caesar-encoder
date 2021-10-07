using System;
using Bilgi_Sistemleri.Helpers;

namespace Bilgi_Sistemleri
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Enter your Key");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data");

            string cipherText = Encoder.Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = Encoder.Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");

            string val = "abc";
            string encrypt = "";
            for (int iChar = 0; iChar < val.Length; iChar++)
            {
                encrypt += (char) (val[iChar] + 3);
            }

            string decrypt = "";
            for (int iChar = 0; iChar < encrypt.Length; iChar++)
            {
                decrypt += (char) (encrypt[iChar] - 3);
            }
        }
    }
}