public class Solution
{
    public static void Main()
    {

    }
    public string LongestPalindrome(string s)
    {
        int n = s.Length;
        char[] curr = s.ToCharArray();
        char[] reverse = new char[n];
        for (int i = 0; i < n; i++)
        {
            reverse[i] = curr[n - 1 - i];
        }

        //lcs -> longest common sub string in curr and reverse 
        int[,] dp = new int[n + 1, n + 1];
        for (int i = 0; i <= n; i++)
        {
            dp[n, i] = 0;
            dp[i, n] = 0;
        }

        int maxLen = 0;
        int start = -1;
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                if (curr[i] == reverse[j])
                {
                    dp[i, j] = 1 + dp[i + 1, j + 1];
                    if (j + dp[i, j] - 1 == n - 1 - i)
                    {
                        if (maxLen < dp[i, j])
                        {
                            maxLen = dp[i, j];
                            start = i;
                        }
                    }

                }
                else
                {
                    dp[i, j] = 0;
                }
            }
        }

        return s.Substring(start, maxLen);
    }

}