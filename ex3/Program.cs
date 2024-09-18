using System;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 測試isUpperCase函式
            Console.WriteLine(isUpperCase("ABCD")); // returns true
            Console.WriteLine(isUpperCase("")); // returns false
            Console.WriteLine(isUpperCase("aBCD")); // returns false

            // 測試isAllUpperCase函式
            Console.WriteLine(isAllUpperCase("ABCD")); // returns true
            Console.WriteLine(isAllUpperCase("")); // returns false
            Console.WriteLine(isAllUpperCase("aBCD")); // returns false
            Console.WriteLine(isAllUpperCase("1234")); // returns true (因為沒有小寫字母)
            Console.WriteLine(isAllUpperCase("A1B2C3")); // returns true

            position("abcd"); // prints -1
            position("AbcD"); // prints A 0
            position("abCD"); // prints C 2

            // 測試position函式
            var result1 = position(""abcd"");
            Console.WriteLine(result1); // returns (W, 5)

            var result2 = position("noUpperCase");
            Console.WriteLine(result2); // returns (null, -1)

            var result3 = position("Hello");
            Console.WriteLine(result3); // returns (H, 0)

            Console.ReadKey();
        }

        #region upper
        static bool isUpperCase(string input)
        {
            // 檢查字串是否為空或null
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // 取得字串的第一個字元
            char firstChar = input[0];

            // 檢查第一個字元是否為大寫字母
            return firstChar >= 'A' && firstChar <= 'Z';
        }
        #endregion

        #region upper2
        static bool isAllUpperCase(string input)
        {
            // 檢查字串是否為空或null
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // 檢查字串中的每個字元是否為大寫字母
            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region position
        static (char? letter, int index) position(string input)
        {
            // 檢查字串是否為空或null
            if (string.IsNullOrEmpty(input))
            {
                return (null, -1);
            }

            // 遍歷字串中的每個字元
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                // 檢查字元是否為大寫字母
                if (c >= 'A' && c <= 'Z')
                {
                    return (c, i);
                }
            }

            // 如果沒有找到大寫字母，回傳 (null, -1)
            return (null, -1);
        }
        #endregion
    }
}
