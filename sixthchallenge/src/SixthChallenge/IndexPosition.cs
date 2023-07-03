namespace SixthChallenge
{
    public class IndexPosition
    {
        public int Position(string data,int idx)
        {
            int val=0;
            bool check =false;
            int lengthSeq=data.Length;
            for(int i=0; i<lengthSeq; i++)
            {
                string sub="";
                for(int j=0; j<idx; j++)
                {
                    if(!sub.Contains(data[i+j]))
                    {
                        check=true;
                        sub+=data[i+j];
                    }
                    else
                    {
                        check=false;
                        break;
                    }
                }
                if(check==true)
                {
                    val=(i+idx);
                    break;
                }
                }
            return val;    
           
    }
}
}