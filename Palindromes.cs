using System;

class Word
{
  public string StringWord;

  public Word(string word)
  {
    StringWord = word;
  }

  public bool isPalindrome()
  {
    char[] arrayWord = StringWord.ToCharArray();
    char[] reverseCopy = (char[]) arrayWord.Clone();

    Array.Reverse(reverseCopy);

    string stringWord = string.Join(",", arrayWord);    // Convert arrays into strings
    string stringReverse = string.Join(",", reverseCopy);

    if (stringWord == stringReverse)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

class Program
{
  static void Main()
  {
    Console.WriteLine("PALINDROME DETECTOR");
    Console.WriteLine("Enter a word:");
    string userWord = Console.ReadLine();

    Word newWord = new Word (userWord);

    if (newWord.isPalindrome())
    {
      Console.WriteLine("That's a palindrome!");
    }
    else
    {
      Console.WriteLine("That's not a palindrome.");
    }

    Main();
  }
}
