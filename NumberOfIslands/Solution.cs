namespace NumberOfIslands
{
    public class Solution
    {
        public int NumIslands(char[][] input)
        {
            var count = 0;

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j] == '1')
                    {
                        count++;
                        dfs(input, i, j);
                    }
                }
            }


            return count;
        }

        private void dfs(char[][] input, in int i, in int j)
        {
            if (i > input.GetLength(0) || j > input.GetLength(1) || i < 0 || j < 0 || input[i][j] == '0')
            {
                return;
            }

            input[i][j] = '0';
            dfs(input, i - 1, j); // up
            dfs(input, i + 1, j); // down
            dfs(input, i, j - 1); // left 
            dfs(input, i, j + 1); //right
        }
    }
}