using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra");
            string palavra = Console.ReadLine();
            Console.WriteLine(IsPalindromo(palavra));
            Console.ReadKey();

        }

        private static bool IsPalindromo(string palavra)
        {
            palavra = palavra.Replace(" ", "");
            string palindromo = string.Empty;
            var chars = palavra.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", chars[i]);
                palindromo += chars[i];
            }

            Console.WriteLine();
            return palindromo.ToLower() == palavra.ToLower();
        }
    }
}
