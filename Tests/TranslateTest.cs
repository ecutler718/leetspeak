using Xunit;
using System;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class TranslateTest
  {
    //First test: will take a phrase from the user that it will translate.
    [Fact]
    public void Test1LetterEReplaceWith3()
    {
      //Arrange
      string input = "heel";
      string returnString = "h33l";

      //Act
      string newTranslator = Translator.Translate(input);

      //Assert
      Assert.Equal(newTranslator, returnString);
    }


  }
}
