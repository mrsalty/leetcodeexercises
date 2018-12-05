namespace LeetCodeExercises.Algorithms
{
    public class AddBinary
    {
        /// <summary>
        /// https://leetcode.com/problems/add-binary/
        /// Given two binary strings, return their sum (also a binary string).
        /// The input strings are both non-empty and contains only characters 1 or 0.
        /// </summary>
        public class Solution
        {
            public string AddBinary(string a, string b)
            {
                var result = string.Empty;
                var carry = false;

                if (a.Length > b.Length)
                    b = b.PadLeft(a.Length, '0');
                else
                    a = a.PadLeft(b.Length, '0');

                for (int i = a.Length - 1; i >= 0; i--)
                {
                    result = BinarySum(a[i] != '0', b[i] != '0', ref carry) + result;
                }
                return carry ? "1" + result : result;
            }

            private string BinarySum(bool a, bool b, ref bool carry)
            {
                var res = a ^ b ^ carry;
                carry = a && b || a && carry || b && carry;
                return res ? "1" : "0";
            }
        }
    }
}
