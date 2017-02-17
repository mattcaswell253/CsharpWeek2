using System;
using System.Collections.Generic;

 namespace RepeatCounterApp.Objects
 {
     public class RepeatCounter
     {

      public int answer = 0;

      public int CountRepeats(string lookWord, string sentence)
      {
        if (lookWord != sentence)
        {
          answer = 0;
        }
        else if (lookWord == sentence)
        {
          answer = 1;
        }
        return answer;
      }
    }
  }
