using System;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class Translator
  {
    public static string Translate(string input)
    {
      //code goes here
      char[] array = input.ToCharArray();
      for (int i = 0; i <array.Length; i++)
      {
        if (array[i] == Convert.ToChar('e'))
        {
         array[i] = Convert.ToChar("3");
        }
      }
      string result = string.Join("", array);
      return result;
    }
  }
}
