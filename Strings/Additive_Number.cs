public class Solution
{
    public bool IsAdditiveNumber(string num)
    {
        char[] arr = num.ToCharArray();
        return sol(arr, 0, null, null, 0);
    }

    public bool sol(char[] arr, int index, BigInteger? n1, BigInteger? n2, int count)
    {

        int n = arr.Length;
        //if any of num is null

        if (index == n)
        {
            return count >= 3;
        }

        if (n1 == null || n2 == null)
        {

            BigInteger val = 0;
            for (int i = index; i < n; i++)
            {

                if (arr[index] == '0' && i > index)
                {
                    break;
                }
                val = (val * 10) + (arr[i] - '0');

                if (n1 == null)
                {
                    if (sol(arr, i + 1, val, null, count + 1))
                    {
                        return true;
                    }

                }
                else
                {
                    if (sol(arr, i + 1, n1, val, count + 1))
                    {
                        return true;
                    }
                }
            }
        }


        // both nums are present
        if (n1.HasValue && n2.HasValue)
        {
            BigInteger sum = (n1.Value + n2.Value);
            string str = (n1.Value + n2.Value).ToString();

            if (index + str.Length > arr.Length)
            {
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != arr[index + i])
                {
                    return false;
                }
            }

            n1 = n2;
            n2 = sum;

            return sol(arr, index + str.Length, n1, n2, count + 1);
        }

        return false;


    }
}