using Nancy;
using System.Collections.Generic;
using LeetSpeak;

namespace LeetTranslate
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ => {
        return View["index.cshtml"];
      };
      Post["/phrase"]= _ => {
        string newPhrase = Translator.Translate(Request.Form["userInput"]);
        return View ["index.cshtml", newPhrase];
      };
    }
  }
}
