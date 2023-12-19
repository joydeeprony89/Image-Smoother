namespace Image_Smoother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            var img = new int[3][] { new int[] { 100, 200, 100 }, new int[] { 200, 50, 200 }, new int[] { 100, 200, 100 } };
            var ans = sol.ImageSmoother(img);
        }
    }

    public class Solution
    {
        public int[][] ImageSmoother(int[][] img)
        {
            int ROW = img.Length;
            int COL = img[0].Length;
            var ans = new int[ROW][];

            for (int r = 0; r < ROW; r++)
            {
                ans[r] = new int[COL];
                for (int c = 0; c < COL; c++)
                {
                    ans[r][c] = 0;
                    int total = 0; int count = 0;
                    for (int i = r - 1; i <= r + 1; i++)
                    {
                        for (int j = c - 1; j <= c + 1; j++)
                        {
                            // check for out of bound
                            if (i < 0 || j < 0 || i == ROW || j == COL) continue;
                            total += img[i][j];
                            count++;
                        }
                    }
                    ans[r][c] = Math.Abs(total / count);
                }
            }

            return ans;
        }
    }
}
