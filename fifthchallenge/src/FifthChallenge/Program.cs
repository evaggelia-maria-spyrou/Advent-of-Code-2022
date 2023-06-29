namespace FifthChallenge{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://adventofcode.com/2022/day/5/input";
            var cookies = "sessionCookies";
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Cookie", $"session={cookies}");
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<string> dataList = new List<string>(data.Split("\n"));
                MakeTheTables makeTheTables=new MakeTheTables();
                SequenceOfTheLastCrates seq=new SequenceOfTheLastCrates();
                //Create the table of stacks of crates
                var tableOfCrates=makeTheTables.MakeTheTableOfTheCrates(dataList);
                //Create the table of steps and moves of crates
                var tableOfSteps=makeTheTables.MakeTheTableOfSteps(dataList);
                //Task1
                seq.TaskOne(tableOfCrates,tableOfSteps);
                //Task2
                seq.TaskTwo(tableOfCrates,tableOfSteps);




              
               
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
        }
    }
}