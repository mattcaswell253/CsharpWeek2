using System;
using System.Collections.Generic;

 namespace RepeatCounterApp.Objects
 {
     public class RepeatCounter
     {

      public int answer = 0;
      public string[] lookForWord;

      public int CountRepeats(string lookWord, string sentence)
      {
        lookForWord = sentence.Split();
        for(int i = 0; i < lookForWord.Length; i++)
        {
          if (lookForWord[i] == lookWord)
          {
            answer += 1;
          }
          else
          {
            answer += 0;
          }
        }


        return answer;
      }
    }
  }
