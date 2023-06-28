using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdChallenge
{
    class CountTheValueOfChar {
        static async Task Main(string[] args)
        {
            var url = "https://adventofcode.com/2022/day/3/input";
            var cookies = "sessionCookies";

            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Cookie", $"session={cookies}");
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<string> racksuckList = new List<string>(data.Split("\n"));
                List<List<string>> seperateItems = new List<List<string>>();
                
                foreach (var item in racksuckList)
                {
                    int length = item.Length;
                    int middle = length / 2;
                    List<string> items = new List<string>() { item.Substring(0, middle), item.Substring(middle) };
                    seperateItems.Add(items);
                }
                ValueOfLetters valueOfLetters = new ValueOfLetters();
                int totalPriorities = 0;
                foreach(var elem in seperateItems)
                {
                    var commonElem = elem[0].Intersect(elem[1]);
                    foreach (char commonChar in commonElem)
                    {
                        totalPriorities += valueOfLetters.Value(commonChar);
                    }
                }

                Console.WriteLine("The sum of the priorities: "+ totalPriorities.ToString());
                List<List<string>> groupOfElves = new List<List<string>>();
                int numberOfElves = 3;
                int numberOfgroups = (racksuckList.Count()-1) / numberOfElves;
                for(int i=0; i<numberOfgroups; i ++)
                {
                    groupOfElves.Add(racksuckList.Skip(i * numberOfElves).Take(numberOfElves).ToList());

                }
                int totalGroupsPriorities = 0;
                foreach(var elem in groupOfElves)
                {
                    var commonElemFirstComparison = elem[0].Intersect(elem[1]);
                    var commonElemSecondComparison = commonElemFirstComparison.Intersect(elem[2]);
                    foreach(char commonChar in commonElemSecondComparison)
                    {

                        totalGroupsPriorities += valueOfLetters.Value(commonChar);

                    }

                }
                Console.WriteLine("The sum of group's priorities : " + totalGroupsPriorities.ToString());
                
                

            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
            Console.ReadLine();

        }
    }
}
   
