namespace FifthChallenge
{
    public class SequenceOfTheLastCrates
    {
        public void TaskOne(List <List<char>> table1,List<List<int>> table2)
        {
            foreach (var step in table2)
                {
                    int n=0;
                    while(n<step[0])
                    {
                        
                        table1[step[2]-1].Insert(0, table1[step[1] - 1][0]);
                        table1[step[1] - 1].RemoveAt(0);
                        n++;
                    }
                }

                Console.WriteLine("The first Task");                                   
                foreach(var element in table1)
                {
                    
                    Console.WriteLine(element[0]);

                }

        }
        public void TaskTwo(List <List<char>> table1,List<List<int>> table2)
        {
            foreach (var step in table2)
                {
                    List<char> list=new List<char>();
                    int n=0;
                    while(n<step[0])
                    {                        
                            list.Add(table1[step[1] - 1][0]);
                             //table1[step[2]-1].Insert(0, table1[step[1] - 1][0]);
                            table1[step[1] - 1].RemoveAt(0);
                            n++;                      
                    }
                   
                    table1[step[2]-1].InsertRange(0,list);

                }

                Console.WriteLine("The second Task");                                   
                foreach(var element in table1)
                {
                    Console.WriteLine(element[0]);

                }

        }
        
    }
}