using System.Text.RegularExpressions;

namespace FifthChallenge
{
    public class MakeTheTables
    {
        public List <List<char>>  MakeTheTableOfTheCrates(List<string> data )
        {
            List <List<char>> table = new List<List<char>>();
                for(var i=0; i<9; i++)
                {
                    List<char> characterList=new List<char>(data[i].Select(e=>e));
                    
                    table.Add(characterList);
                }
                MakeTheTables makeTheTables=new MakeTheTables();
                var crates=makeTheTables.TransposeArray(table);
                return makeTheTables.FindTheLetters(crates);


        }

        public List<List<int>> MakeTheTableOfSteps(List<string> data )
        {
            List <List<int>> tableNumbers = new List<List<int>>();
                var pattern=@"\d+";
                var regex=new Regex(pattern);
                foreach(var listItem in data)
                {
                    if(listItem.StartsWith("move"))
                    {
                        var numbers = regex.Matches(listItem).Select(match => int.Parse(match.Value)).ToList();
                        if(numbers.Count>0)
                        {
                            tableNumbers.Add(numbers);
                        }
                    } 
                }

                return tableNumbers;
            

        }

        public List<List<char>>  TransposeArray(List <List<char>> data)
        {
                int rows = data.Count;
                int columns = data[0].Count;
                List<List<char>> transposedList = new List<List<char>>();
                for (int j = 0; j < columns; j++)
                {
                    List<char> column = new List<char>();
                    for (int i = 0; i < rows; i++)
                    {
                        column.Add(data[i][j]);
                    }
                    transposedList.Add(column);
                }

                return  transposedList;


        }

         public List<List<char>> FindTheLetters(List<List<char>> data)
         {
            List<List<char>> transposedListLetters = new List<List<char>>();
                foreach(var character in data)
                {
                    List<char> letters = new List<char>(character.Where(e=>Char.IsUpper(e)));
                    
                    if(letters.Count>0)
                    {
                        transposedListLetters.Add(letters);

                    }
                    
                    
                }
                return  transposedListLetters;

         }


    }
}