//Simple Console application which encrypts text based on the Caeser Cipher
//each letter is shifted 3 places in the alphabet

using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //get the users message
            Console.WriteLine("Enter the message you would like to encrypt:");
            string message = Console.ReadLine().ToLower();

            string encrypted = Encrypt(message, alphabet);
            Console.WriteLine($"Encrypted message = {encrypted}");
            Console.WriteLine($"Decrypted message = {Decrypt(encrypted, alphabet)}");
        }

        static string Encrypt(string message, char[] alphabet)
        {
            //convert the message to a char array, and create a new empty array of the same length to add new values to
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            //loop through each character in the message, move the character 3 positions and add to new array
            for (int i = 0; i < secretMessage.Length; i++)
            {
                //get the character of the users message
                char letter = secretMessage[i];

                //skip special charaters and numbers
                if (alphabet.Contains(letter))
                {
                    //get the position in the alphabet array and increase by 3, then add to new array
                    int letterPosition = Array.IndexOf(alphabet, letter);
                    //the modulo bit prevents the array index out of bounds exeption
                    //E.G 28 % 26 = 2
                    int newletterPosition = (letterPosition + 3) % alphabet.Length;
                    char newLetter = alphabet[newletterPosition];
                    encryptedMessage[i] = newLetter;
                }
                else
                {
                    encryptedMessage[i] = letter;
                }


            }
            //join the char array back into a string, ignoring whitespace
            return String.Join("", encryptedMessage);
        }

        static string Decrypt(string encryptedMessage, char[] alphabet)
        {
            //convert the message to a char array, and create a new empty array of the same length to add new values to
            char[] secretMessage = encryptedMessage.ToCharArray();
            char[] decryptedMessage = new char[secretMessage.Length];

            //loop through each character in the message, move the character 3 positions and add to new array
            for (int i = 0; i < secretMessage.Length; i++)
            {
                //get the character of the users message
                char letter = secretMessage[i];

                //skip special charaters and numbers
                if (alphabet.Contains(letter))
                {
                    //get the position in the alphabet array and increase by 3, then add to new array
                    int letterPosition = Array.IndexOf(alphabet, letter);
                    //the modulo bit prevents the array index out of bounds exeption
                    //E.G 28 % 26 = 2
                    int newletterPosition = (letterPosition - 3) % alphabet.Length;
                    char newLetter = alphabet[newletterPosition];
                    decryptedMessage[i] = newLetter;
                }
                else
                {
                    decryptedMessage[i] = letter;
                }


            }
            //join the char array back into a string, ignoring whitespace
            return String.Join("", decryptedMessage);
        }
    }
}