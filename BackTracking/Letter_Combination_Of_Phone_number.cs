public class Solution
{
    List<string> ans;
    public List<string> LetterCombinations(string digits)
    {
        ans = new List<string>();
        sol(digits, 0, "");
        return ans;
    }

    public void sol(string s, int index, string curr)
    {
        if (index == s.Length)
        {
            if (curr.Length > 0)
            {
                ans.Add(curr);
            }
            return;
        }

        int num = s[index] - '0';
        int skip = (num - 2) * 3;
        if (num == 8 || num == 9)
        {
            skip++;
        }
        int count = num == 7 || num == 9 ? 4 : 3;

        char ch = (char)('a' + skip);
        while (count-- > 0)
        {
            curr = curr + ch;
            sol(s, index + 1, curr);
            curr = curr.Substring(0, curr.Length - 1);
            ch = (char)(ch + 1);
        }
    }
}
