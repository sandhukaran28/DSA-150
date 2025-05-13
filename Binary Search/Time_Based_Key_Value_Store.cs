public class TimeMap
{
    Dictionary<string, List<(int, string)>> hm;
    public TimeMap()
    {
        hm = new Dictionary<string, List<(int, string)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!hm.ContainsKey(key))
        {
            List<(int, string)> ls = new List<(int, string)>();
            ls.Add((timestamp, value));
            hm.Add(key, ls);
        }
        else
        {
            List<(int, string)> ls = hm[key];
            ls.Add((timestamp, value));
        }
    }

    public string Get(string key, int timestamp)
    {
        if (!hm.ContainsKey(key))
        {
            return "";
        }
        List<(int, string)> ls = hm[key];
        int l = 0, r = ls.Count - 1;
        int index = -1;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (ls[mid].Item1 == timestamp)
            {
                return ls[mid].Item2;
            }
            else if (ls[mid].Item1 > timestamp)
            {
                r = mid - 1;
            }
            else
            {
                index = mid;
                l = mid + 1;
            }
        }
        if (index != -1)
        {
            return ls[index].Item2;
        }
        else
        {
            return "";
        }

    }
}
