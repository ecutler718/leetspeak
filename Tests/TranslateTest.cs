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
    [Fact]
    public void Test2LetterOReplaceWith0()
    {
      //Arrange
      string input = "woof";
      string returnString = "w00f";

      //Act
      string newTranslator = Translator.Translate(input);

      //Assert
      Assert.Equal(newTranslator, returnString);
    }
    [Fact]
    public void Test3LetterCapitalIReplaceWith1()
    {
      //Arrange
      string input = "India";
      string returnString = "1ndia";

      //Act
      string newTranslator = Translator.Translate(input);

      //Assert
      Assert.Equal(newTranslator, returnString);
    }


  }
}
