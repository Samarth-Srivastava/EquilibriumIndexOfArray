class Solution {
    public int solve(List<int> A) {
        int N = A.Count();
        List<int> pfSum_A = new List<int>();
        int pfSum = 0;
        for(int i = 0; i < N; i++){
            pfSum = pfSum + A[i];
            pfSum_A.Add(pfSum);
        }
        for(int i = 0; i < N; i++){
            int left = 0;
            int right = 0;
            if(i == 0) left = 0;
            else left = pfSum_A[i-1];
            right = pfSum_A[N-1] - pfSum_A[i];

            if(left == right)
                return i;
        }
        return -1;
    }
}
