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
    public List<string> FindAnagrams()
    {
      int InputtedWordLength = _inputtedWord.Length;
      List<string> returnedWords = new List<string> {};
      char[] splitUserWord = _inputtedWord.ToCharArray();
      Array.Sort(splitUserWord);
      foreach (string word in _possibleAnagrams)
      {
        if(InputtedWordLength == word.Length)
        {
          char[] splitListWord = word.ToCharArray();
          Array.Sort(splitListWord);
          int index = 0;
          foreach (char letter in splitUserWord)
          {
            if (letter != splitListWord[index])
            {
              break;
            }
            index++;
          }
          returnedWords.Add(word);
        }
      }
    return returnedWords;
    }
  }
}
