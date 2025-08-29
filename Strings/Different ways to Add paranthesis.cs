public class Solution
{
    public IList<int> DiffWaysToCompute(string expression)
    {
        Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();
        return sol(expression, dic);
    }


    public List<int> sol(string exp, Dictionary<string, List<int>> dic)
    {
        if (dic.ContainsKey(exp))
        {
            return dic[exp];
        }
        List<int> ans = new List<int>();
        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == '+' || exp[i] == '*' || exp[i] == '-')
            {
                string a = exp.Substring(0, i);
                string b = exp.Substring(i + 1);

                List<int> ls1 = sol(a, dic);
                List<int> ls2 = sol(b, dic);

                foreach (int n1 in ls1)
                {
                    foreach (int n2 in ls2)
                    {
                        ans.Add(apply(n1, n2, exp[i]));
                    }
                }
            }
        }

        if (ans.Count == 0)
        {
            ans.Add(int.Parse(exp));
        }

        return dic[exp] = ans;
    }

    public int apply(int a, int b, char op)
    {
        switch (op)
        {
            case '+':
                {
                    return a + b;
                }
            case '-':
                {
                    return a - b;
                }
            case '*':
                {
                    return a * b;
                }
        }
        return 0;
    }
}