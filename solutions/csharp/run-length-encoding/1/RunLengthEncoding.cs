using System.Text;
public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        StringBuilder sb = new StringBuilder();
        int i =0;
        while(i<input.Length)
        {
            char c = input[i];
            int count = 0;

        while(i<input.Length && input[i] == c){
            count++;
            i++;
        }
            if (count>1){
                sb.Append(count);
            }
            sb.Append(c);
        }
        return sb.ToString();
    }

    public static string Decode(string input)
    {
        StringBuilder sb = new StringBuilder();
        int count = 0;
        foreach (char c in input){
            if (char.IsDigit(c)){
                count = count *10 +(c-'0');
            }
            else{
                if(count ==0){
                    count = 1;
                }
                sb.Append(c, count);
                count = 0;
            }
        }
        return sb.ToString();
    }
}
