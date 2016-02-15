using System.Collections.Generic;

namespace LeetSpeak
{
  public class Sentence
  {
    //code goes here
    private string _userPhrase;

    public Sentence(string userPhrase)
    {
      _userPhrase = userPhrase;
    }

    public string GetUserPhrase()
    {
      return _userPhrase;
    }
    public void SetUserPhrase(string userPhrase)
    {
      _userPhrase = userPhrase;
    }

    // public static Translate(Sentence userPhrase)
    // {
    //   return userPhrase;
    // }
  }
}
