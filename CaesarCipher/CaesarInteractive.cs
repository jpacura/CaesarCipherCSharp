using System;

namespace CaesarCipher
{
    class CaesarInteractive
    {
        // This is the interactive console portion of this code
        // It uses the other class for the encrypt and decrypt function

        static void Main(string[] args)
        {
            Console.WriteLine("Caesar Cipher Interactive");
            Console.WriteLine("By Joseph Pacura");
            Console.Write("\n(E)ncrypt or (D)ecrypt?");
            String selection = Console.ReadLine();
            selection = selection.ToLower();
            bool operation = false;
            if (selection.Equals("e"))
            {
                operation = true;
            }
            else if (!selection.Equals("d"))
            {
                Console.WriteLine("Invalid Selection. Quitting");
                Environment.Exit(0);
            }

            int k = 0;
            bool keyValid = false;
            do
            {
                Console.WriteLine("Enter the Key:");
                String keyLine = Console.ReadLine();
                keyValid = int.TryParse(keyLine, out k);
            }
            while(!keyValid);

            Console.WriteLine("Enter the Text:");
            String s = Console.ReadLine();

            if (operation)
            {
                Console.WriteLine(CaesarCipher.encrypt(s, k));
            }
            else
            {
                Console.WriteLine(CaesarCipher.decrypt(s, k));
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
