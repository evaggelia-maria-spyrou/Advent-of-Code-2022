using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondChallenge
{
     class CountTheTotalScoreTaskOne
    {

        public int CountWinsTaskOne(string first, string second)
        {
            int cnt = 0;
            //A
            switch (first)
            {
                case "A":
                    if (second == "Y")
                    {
                        cnt += (2 + 6);
                        break;
                    }
                    else if (second == "X")
                    {
                        cnt += (1 + 3);
                        break;
                    }
                    else
                    {
                        cnt += (3 + 0);
                        break;
                    }
                case "B":
                    if (second == "Y")
                    {
                        cnt += (2 + 3);
                        break;
                    }
                    else if (second == "X")
                    {
                        cnt += (1 + 0);
                        break;
                    }
                    else
                    {
                        cnt += (6 + 3);
                        break;
                    }
                case "C":
                    if (second == "Y")
                    {
                        cnt += (2 + 0);
                        break;
                    }
                    else if (second == "X")
                    {
                        cnt += (1 + 6);
                        break;
                    }
                    else
                    {
                        cnt += (3 + 3);
                        break;
                    }

                    
            }
            return cnt;
        }
    }
}
