using Nancy;
using System.Collections.Generic;
using Anagrams.Objects;


namespace Anagrams //replace with your desired namespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result_form"] = _ =>{
        List<string> newList = new List<string>{Request.Form["anagram-one"], Request.Form["anagram-two"]};
        Anagram newAnagram = new Anagram(Request.Form["user-word"], newList);
        List<string> finalResults = newAnagram.FindAnagrams();
        return View["result.cshtml", finalResults];
      };
    }
  }
}
