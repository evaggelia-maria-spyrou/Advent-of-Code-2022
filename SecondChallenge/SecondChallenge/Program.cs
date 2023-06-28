using SecondChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


    class CountStrategyScores
    {
        
        static async Task Main(string[] args)
        {
            var url = "https://adventofcode.com/2022/day/2/input";
            var cookies = "sessionCookies";

            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Cookie", $"session={cookies}");
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<string> strategyList = new List<string>(data.Split("\n"));
                List<List<string>> strategyListTwo = new List<List<string>>();
                foreach (string character in strategyList)
                {
                    List<string> stringElemOfEachList = new List<string>(character.Split(" "));
                    strategyListTwo.Add(stringElemOfEachList);
                }

                CountTheTotalScoreTaskOne scoreTaskOne = new CountTheTotalScoreTaskOne();
                CountTheTotalScoreTaskTwo scoreTaskTwo = new CountTheTotalScoreTaskTwo();
                int totalTaskOne = 0;
                int totalTaskTwo = 0;
                for (int i = 0; i < strategyListTwo.Count-1; i++)
                {                    
                    totalTaskOne += scoreTaskOne.CountWinsTaskOne(strategyListTwo[i][0].ToString(), strategyListTwo[i][1].ToString());
                    totalTaskTwo += scoreTaskTwo.CountWinsTaskTwo(strategyListTwo[i][0].ToString(), strategyListTwo[i][1].ToString());
                }
                Console.WriteLine("Total Task One : "+ totalTaskOne.ToString());
                Console.WriteLine("Total Task Two : " + totalTaskTwo.ToString());
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
        }
    }
