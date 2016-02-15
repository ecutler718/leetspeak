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
        else if (array[i] == Convert.ToChar("o")) {
              array[i] = Convert.ToChar("0");
        }
        else if (array[i] == Convert.ToChar("I")){
              array[i] = Convert.ToChar("1");
        }
      }
      string result = string.Join("", array);
      return result;
    }
  }
}
