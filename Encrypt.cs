using System;

class Encrypt
{
  static void Main()
  {
    askForPhrase();
  }

  static void askForPhrase()
  {
    Console.WriteLine("Enter a phrase to be encrypted: ");
    string inputPhrase = Console.ReadLine();
    string encryptedPhrase = inputPhrase.Replace("a", "bartholomew");
    Console.WriteLine("Here is your encrypted phrase: " + encryptedPhrase);
  }
}