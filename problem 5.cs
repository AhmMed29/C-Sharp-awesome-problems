in this problem i used a new class --> StringBuilder
i used this class to edit my string effectively
to use it do not forget to call this in the heading line
"using System.Text;"


using System;
using System.Text;
public class Kata
{
    public static string Remove_char(string s)
    {
      StringBuilder result = new StringBuilder();
        if (s.Length > 2)
        {
            for(int i =1;i<s.Length - 1;i++)
            {
                result.Append(s[i]);
            }
          return result.ToString();
        }
        return "";
    }
}