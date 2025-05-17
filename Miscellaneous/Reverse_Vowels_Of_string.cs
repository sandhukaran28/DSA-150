public class Solution
{
    public string ReverseVowels(string s)
    {
        int l = 0, r = s.Length - 1;
        char[] arr = s.ToCharArray();
        while (l < r)
        {
            while (!isVowel(Char.ToLower(arr[l])) && l < r)
            {
                l++;
            }
            while (!isVowel(Char.ToLower(arr[r])) && r > l)
            {
                r--;
            }
            if (l < r)
            {
                char temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }

        }

        return new String(arr);
    }

    public static bool isVowel(char s)
    {

        if (s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u')
        {
            return true;
        }
        return false;
    }
}