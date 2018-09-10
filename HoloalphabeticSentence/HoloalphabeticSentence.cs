using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            input=input.ToLower();
            int s=input.Length;
            int k=0;
        for(int i=0;i<26;i++)
         {
          k=0;
         for(int j=0;j<s;j++)
         {
             if(alphabets[i]==input[j])
             {
                 k++;
                 break;
             }
         }
         if(k==0)
         {
             break;
         }
         }
         if(k==0)
         {
          return false;
          }
         else
         {
           
             return true;
           }
       }
 }
           
        }