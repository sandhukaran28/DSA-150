public class Solution
{
    public int[] PlusOne(int[] arr)
    {
        int carry = 1;
        int len = arr.Length;
        for (int i = len - 1; i >= 0; i--)
        {
            arr[i] = arr[i] + carry;
            carry = 0;
            if (arr[i] > 9)
            {
                carry = arr[i] / 10;
                arr[i] = arr[i] % 10;
            }
            else
            {
                break;
            }
        }

        if (carry == 0)
        {
            return arr;
        }

        int[] res = new int[len + 1];
        res[0] = carry;
        for (int i = 1; i < len + 1; i++)
        {
            res[i] = arr[i - 1];
        }

        return res;
    }
}

// better solution
public class Solution
{
    public int[] PlusOne(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] != 9)
            {
                arr[i]++;
                return arr;
            }
            arr[i] = 0;
        }

        int[] res = new int[arr.Length + 1];
        res[0] = 1;

        return res;
    }
}