using System;

namespace CaesarCipher
{
    class CaesarCipher
    {
        public static String encrypt(String text, int key)
        {
            String ret = "";

            // Convert string to uppercase
            text = text.ToUpper();

            // Loop through the string one character at a time
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                // Skip character if it is not a capital letter
                // This allows us to leave punctuation alone
                if (c > 'Z' || c < 'A')
                {
                    ret = ret + c;
                    continue;
                }

                // Add the key to the existing letter to shift it
                char n = (char)(c + key);

                // Subtract 26 from the character if it wraps around the alphabet
                while (n > 'Z')
                {
                    n = (char)(n - 26);
                }

                ret = ret + n;
            }

            return ret;
        }

        public static String decrypt(String text, int key)
        {
            String ret = "";
            text = text.ToUpper();

            // Loop through the string one character at a time
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                // Skip character if it is not a capital letter
                // This allows us to leave punctuation alone
                if (c > 'Z' || c < 'A')
                {
                    ret = ret + c;
                    continue;
                }

                // Subtract the key from the existing letter to shift it
                char n = (char)(c - key);

                // Add 26 to the character if it wraps around the alphabet
                while (n < 'A')
                {
                    n = (char)(n + 26);
                }

                ret = ret + n;
            }

            return ret;
        }
    }
}
