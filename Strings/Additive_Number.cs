public class Solution {
    public bool IsAdditiveNumber(string num) {
        return sol(0, 0,0,num,0);
    }

    public bool sol(BigInteger n1, BigInteger n2,int idx,string num,int count){

        if(idx == num.Length){
            return count >= 3;
        }

            for(int i=idx;i <num.Length;i++){
                if(num[idx] == '0' && i > idx) break;

                BigInteger n3  = BigInteger.Parse(num.Substring(idx,i-idx+1));
                if(count < 2){
                if(count == 0){
                    if(sol(n3, n2,i+1,num,count+1)){
                        return true;
                    }
                }
                else{
                    if(sol(n1, n3,i+1,num,count+1)){
                        return true;
                    }
                }
                }
                else{
                BigInteger add  = BigInteger.Add(n1,n2);
                 if(add.Equals(n3)){
                return sol(n2,add,i+1, num,count+1);
            }
                }
            }
            
        return false;
    }
}