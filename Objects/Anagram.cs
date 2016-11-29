using System;
using System.Collections.Generic;

namespace Anagrams.Objects
{
  public class Anagram
  {
    private string _inputtedWord;
    private List<string> _possibleAnagrams = new List<string> {};

    private static List<string> _anagrams = new List<string> {};

    public Anagram(string InputtedWord, List<string> PossibleAnagrams)
    {
      _inputtedWord = InputtedWord;
      _possibleAnagrams = PossibleAnagrams;
    }

    public List<bool> ComapareLength()
    {
      int InputtedWordLength = _inputtedWord.Length;
      int index = 0;
      List<bool> returnedWords = new List<bool> {};
      char[] splitUserWord = _inputtedWord.ToCharArray();
      Array.Sort(splitUserWord);
      Console.WriteLine(splitUserWord);
      foreach (string word in _possibleAnagrams)
      {
        if(InputtedWordLength == word.Length)
        {
          char[] splitListWord = word.ToCharArray();
          Array.Sort(splitListWord);
          Console.WriteLine(splitListWord);

          foreach (char letter in splitUserWord)
          {
            if (letter != splitListWord[index])
            {
              Console.WriteLine(letter);
              returnedWords.Add(false);
              //break;
            }
            else
            {
              returnedWords.Add(true);
            }
            index++;
          }
        //  returnedWords.Add(true);
        }else
        {
          returnedWords.Add(false);
          //returnedWords.Add(false);
        }
      }
    return returnedWords;
    }
  }
}
