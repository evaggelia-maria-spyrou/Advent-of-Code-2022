using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

    class CountCalories
    {
        static async Task Main(string[] args)
        {
            var url = "https://adventofcode.com/2022/day/1/input";

            var cookies = "sessionCookies";
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Cookie", $"session={cookies}");
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<string> listsOfElvesCalories = new List<string>(data.Split("\n\n"));

                IDictionary<string, int> dictOfEachElfTotalCalories = new Dictionary<string, int>();

                for (int i = 0; i < listsOfElvesCalories.Count; i++)
                {
                    List<int> elemToInt = new List<int>();
                    List<string> stringElemOfEachList = new List<string>(listsOfElvesCalories[i].Split("\n"));
                    foreach (string elem in stringElemOfEachList)
                    {
                        if (int.TryParse(elem, out int val))
                        {
                            elemToInt.Add(val);
                        }
                    }
                    var sum = elemToInt.Sum();
                    dictOfEachElfTotalCalories.Add("elf " + i.ToString(), sum);
                }
                //the elf with the most calories
                var elfWithMaxCalories = dictOfEachElfTotalCalories.FirstOrDefault(e => e.Value == dictOfEachElfTotalCalories.Values.Max()).Key;
                Console.WriteLine("Elf with the most calories: {0}\nNumber of calories:{1}", elfWithMaxCalories, dictOfEachElfTotalCalories[elfWithMaxCalories]);
                //the top three elves with the most calories
                var sumOfTopThreeElves = dictOfEachElfTotalCalories.Values.OrderByDescending(e => e).Take(3).Sum();
                Console.WriteLine("The total number of top three Elves:" + sumOfTopThreeElves);
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
        }
    }


