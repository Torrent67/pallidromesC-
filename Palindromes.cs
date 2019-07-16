using System;

class Word
{
  public string StringWord;
  public bool IsPalindrome;

  public Word(string word)
  {
    StringWord = word;
    IsPalindrome = true;
  }

  public void PalindromeChecker()
  {
    for (int i = 0; i < StringWord.Length; i++)
    {
      if (StringWord[i] != StringWord[StringWord.Length - 1 - i])
      {
        IsPalindrome = false;
      }
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
    newWord.PalindromeChecker();

    if (newWord.IsPalindrome)
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
