using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SecondChallenge
{
    class CountTheTotalScoreTaskTwo
    {
        public int CountWinsTaskTwo(string first, string second)
        {
            int cnt = 0;
            switch (second)
            {
                case "Y":
                    if (first == "A")
                    {
                        cnt += (3 + 1);
                        break;
                    }
                    else if (first == "B")
                    {
                        cnt += (3 + 2);
                        break;
                    }
                    else
                    {
                        cnt += (3 + 3);
                        break;
                 
                    }
                case "X":
                    if (first == "A")
                    {
                        cnt += (3 + 0);
                        break;
                    }
                    else if (first == "B")
                    {
                        cnt += (1+0);
                        break;
                    }
                    else
                    {
                        cnt += (2 + 0);
                        break;

                    }
                case "Z":
                    if (first == "A")
                    {
                        cnt += (2 + 6);
                        break;
                    }
                    else if (first == "B")
                    {
                        cnt += (3 + 6);
                        break;
                    }
                    else
                    {
                        cnt += (1+ 6);
                        break;

                    }

            }
            return cnt;


        }
    }
}
