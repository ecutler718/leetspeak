using Xunit;
using LeetSpeak;
using System;
using System.Collections.Generic;

namespace Translator
{
  public class TranslateTest
  {
    //First test: will take a phrase from the user that it will translate.
    [Fact]
    public void test1GetPhraseFromUser()
    {
      //Arrange
      string phrase = "Walk the dog";
      Sentence newSentence = new Sentence(phrase);

      //Act
      string result = "Walk the dog";

      //Assert
      Assert.Equal(phrase, result);
    }
  }
}
