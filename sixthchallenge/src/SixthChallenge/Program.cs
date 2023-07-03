using System.Text.RegularExpressions;

namespace SixthChallenge
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://adventofcode.com/2022/day/6/input";
            var cookies ="SessionCookies";
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Cookie", $"session={cookies}");
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var seq = await response.Content.ReadAsStringAsync();
                //Initialize class IndexPosition                               
                IndexPosition pos=new IndexPosition();
                //First position for four unique characters
                int val=pos.Position(seq,4);
                Console.WriteLine(val);
                //First position for fourteen unique characters
                int val2=pos.Position(seq,14);
                Console.WriteLine(val2);
            }
            else
            {
                Console.WriteLine(response.StatusCode);

            }
        
}}
}
         
            
