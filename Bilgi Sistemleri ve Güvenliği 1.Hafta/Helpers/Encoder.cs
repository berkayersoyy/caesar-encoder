namespace Bilgi_Sistemleri_ve_Güvenliği_1.Hafta.Helpers
{
    public class Encoder
    {
        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }
        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }
    }
}