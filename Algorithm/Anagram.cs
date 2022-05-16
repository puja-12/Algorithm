using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
        public class Anagram
        {
            public bool areAnagram(string firstString, string secondString)
            {
            if (firstString.Length != secondString.Length)
            {
                return false;
            } 
                char[] firstCharsArray = firstString.ToLower().ToCharArray();
                char[] secondCharsArray = secondString.ToLower().ToCharArray();
                Array.Sort(firstCharsArray);
                Array.Sort(secondCharsArray);             
                for (int i = 0; i < firstCharsArray.Length; i++)
                {
                    if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
