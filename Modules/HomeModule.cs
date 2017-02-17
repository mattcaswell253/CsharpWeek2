using Nancy;
using System;
using System.Collections.Generic;
using RepeatCounterApp.Objects;


namespace RepeatCounterApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>  View["index.cshtml"];
            Post["/answer"] = _ => {
              RepeatCounter newCounter = new RepeatCounter();
              int answer = newCounter.CountRepeats(Request.Form["look-word"], Request.Form["sentence"]);
              return View["answer.cshtml", answer];

            };
        }
    }
}
