using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ThirdChallenge
{
     class ValueOfLetters
    {
        public int Value(char letter)
        {
            int cnt = 0;

            if(char.IsUpper(letter))               
            {
                int upperCount = 27;
                for (int i = 65; i <= 90; i++)
                {
                    if (letter == (char)i)
                    {
                        cnt = upperCount;
                        break;
                    }
                    upperCount++;

                }
            }
            else
            {
                int lowerCount = 1;
                for(int i=97; i<=122; i++)
                {
                    if (letter==(char)i)
                    {
                        cnt = lowerCount;
                        break;

                    }
                    lowerCount++;
                }
            }
            return cnt;
        }
    }
}
