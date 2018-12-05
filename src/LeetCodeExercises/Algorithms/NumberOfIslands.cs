namespace LeetCodeExercises.Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-islands/
    /// </summary>
    public class NumberOfIslands
    {
        public class Solution
        {
            public int NumIslands(char[,] grid)
            {
                int count = 0;

                var lenght = grid.GetLength(1);
                var height = grid.GetLength(0);

                for (int row = 0; row < height; row++)
                {
                    for (int column = 0; column < lenght; column++)
                    {
                        if (grid[row, column] == '1')
                        {
                            count++;
                            VisitGraph(grid, row, column);
                        }
                    }
                }


                return count;
            }

            private void VisitGraph(char[,] grid, int row, int column)
            {
                var lenght = grid.GetLength(1);
                var height = grid.GetLength(0);

                if (row > height - 1 || column > lenght - 1 || row < 0 || column < 0 || grid[row, column] != '1')
                {
                    return;
                }

                grid[row, column] = '0';
                
                VisitGraph(grid, row - 1, column);
                VisitGraph(grid, row + 1, column);
                VisitGraph(grid, row, column - 1);
                VisitGraph(grid, row, column + 1);
            }
        }
    }
}
