public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
     for(int i=0;i<strs.Count;i++){
        int count = strs[i].Length;
        encoded += count + "#"+strs[i];
     }
    Console.WriteLine(encoded);
     return encoded;  
    }

    public List<string> Decode(string s) {
         List<string> ls = new List<string>();
        int i = 0;
        while(i < s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            int count = int.Parse(s.Substring(i,j-i));
            string word = s.Substring(j+1,count);
            ls.Add(word);
            i = j + count +1;
        }

         return ls;
   }
}
