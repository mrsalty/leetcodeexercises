using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/word-search/
    /// Given a 2D board and a word, find if the word exists in the grid.
    /// The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring.
    /// The same letter cell may not be used more than once.
    /// </summary>
    public class WordSearch
    {
        public class Solution
        {
            public bool Exist(char[,] board, string word)
            {
                var columns = board.GetLength(1);
                var rows = board.GetLength(0);

                if (word.Length > rows * columns) return false;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        var used = new bool[rows, columns];
                        if (word[0] == board[i, j])
                        {
                            if (ExploreNeighbours(board, i, j, word, 0, used))
                                return true;
                        }
                    }
                }

                return false;
            }

            private bool ExploreNeighbours(char[,] board, int row, int column, string word, int position, bool[,] used)
            {
                if (!used[row, column] && board[row, column] == word[position])
                {
                    if (position == word.Length - 1) return true;
                    used[row, column] = true;
                    var found = false;
                    if (row > 0)
                        found = ExploreNeighbours(board, row - 1, column, word, position + 1, used);
                    if (!found && row < board.GetLength(0) - 1)
                        found = ExploreNeighbours(board, row + 1, column, word, position + 1, used);
                    if (!found && column > 0)
                        found = ExploreNeighbours(board, row, column - 1, word, position + 1, used);
                    if (!found && column < board.GetLength(1) - 1)
                        found = ExploreNeighbours(board, row, column + 1, word, position + 1, used);

                    used[row, column] = found;
                    return found;
                }

                return false;
            }
        }
    }
}
