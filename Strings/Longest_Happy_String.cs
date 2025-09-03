public class Solution
{
    public string LongestDiverseString(int a, int b, int c)
    {
        int[] count = new int[] { a, b, c };
        char[] ch = new char[] { 'a', 'b', 'c' };
        StringBuilder ans = new StringBuilder();
        char lastEle = '#';
        int lastCount = 0;


        while (true)
        {
            int i0 = 0, i1 = 1, i2 = 2;

            //sorting
            if (count[i1] > count[i0])
            {
                (i0, i1) = (i1, i0);
            }
            if (count[i2] > count[i1])
            {
                (i1, i2) = (i2, i1);
            }
            if (count[i1] > count[i0])
            {
                (i0, i1) = (i1, i0);
            }
            bool added = false;
            for (int k = 0; k < 3; k++)
            {
                int i = k == 0 ? i0 : k == 1 ? i1 : i2;
                int chCount = count[i];
                if (chCount == 0) continue;
                int cCount = (lastEle == ch[i] ? lastCount + 1 : 1);

                if (cCount == 3)
                {
                    continue;
                }
                ans.Append(ch[i]);
                lastEle = ch[i];
                count[i]--;
                lastEle = ch[i];
                lastCount = cCount;
                added = true;
                break;
            }

            if (!added)
            {
                break;
            }
        }

        return ans.ToString();
    }


}