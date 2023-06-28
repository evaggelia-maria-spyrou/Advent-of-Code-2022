using System.Xml.Schema;

namespace FourthChallenge
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://adventofcode.com/2022/day/4/input";
            var cookies = "sessionCookies";
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Cookie", $"session={cookies}");
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<string> pairs = new List<string>(data.Split("\n"));

                //Initialize CheckSubet Class
                CheckSubset checkSubset = new CheckSubset();

                int totalOverlaps = 0;
                int totalNumber = 0;

                for (var i= 0; i<pairs.Count-1; i++)
                {                   
                    List<string> elemElem = new List<string>(pairs[i].Split(","));
                    
                    if (checkSubset.IsSubset(elemElem[0], elemElem[1],true))
                    {
                        totalOverlaps++;
                    }
                    if (checkSubset.IsSubset(elemElem[0], elemElem[1], false))
                    {
                        totalNumber++;
                    }                  
                    
                }

                //Part One
                Console.WriteLine("The number of pairs does one range fully contain the other : " + totalOverlaps);

                //Part Two
                Console.WriteLine("The total number of  pairs do the ranges overlap : " + totalNumber);
               
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
        }
    }
}