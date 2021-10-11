using System;
using System.Linq;

namespace Bilgi_Sistemleri.Helpers
{
    public class Encoder
    {
        private static char[] _alphabet = new char[]
        {
            'A', 'B', 'C','Ç' , 'D', 'E', 'F', 'G','Ğ' ,'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö' ,
            'P', 'Q', 'R', 'S','Ş' , 'T', 'U', 'Ü', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'ç','d', 'e', 'f', 'g','ğ', 'h', 'ı','i', 'j', 'k', 'l', 'm', 'n', 'o','ö',
            'p', 'q', 'r', 's','ş', 't', 'u','ü', 'v', 'w', 'x', 'y', 'z',
            '1','2','3','4','5','6','7','8','9','0',' ','`','~','!','\'','^','#','+','$','%','½','&','/','{','(','[',')',']','=','}','?','*','\\','-','_',',','.',';','.',':','<','>','|','@'
        };
        public static string Encipher(string text, int key)
        {
            string encodedMessage = "";
            for (int i = 0; i < text.Length; i++)
            {
                var charIndex = Array.IndexOf(_alphabet, text[i]);
                if (charIndex + key > _alphabet.Length - 1)
                {
                    int shift = (charIndex + key) % _alphabet.Length;
                    encodedMessage += _alphabet[shift];
                }
                else
                {
                    int shift = charIndex + key;
                    encodedMessage += _alphabet[shift];
                }
            }

            return encodedMessage;


        }
        public static string Decipher(string input, int key)
        {
            return Encipher(input, _alphabet.Length - key);
        }
    }

}