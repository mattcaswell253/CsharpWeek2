using System;
using System.Collections.Generic;

 namespace RepeatCounterApp.Objects
 {
     public class RepeatCounter
     {

       public string _startingString;
       public string _lookForWord;


       public RepeatCounter(string startingString, string lookForWord)
       {
         _startingString = startingString;
         _lookForWord = lookForWord;
       }

       public bool InsideWord()
       {
         if(_startingString.Contains(_lookForWord))
         {
           return true;
         }
         else
         {
           return false;
         }

       }

      //  public int CountRepeats()
      //  {
       //
      //
      //    int count1 = 0;
      //
      //    for(int i = 0; i < _startingArray.Length; i++)
      //    {
      //      if(_startingArray[i] = _lookForArray)
      //      {
      //        count++;
      //      }
      //    }
      //    if(count > 0)
      //    {
      //      return count;
      //    }
       //
       //
      //  }

     }
 }
