using System.Globalization;
using System.Text;

namespace TaskLib
{
    public static class Facebook
    {
        public static int NumberOfWays(int[] arr, int k)
        {
            var count = 0; 
                        
            for (var i = 0; i < arr.Length; i++)
                for (var j = i + 1; j < arr.Length; j++)
                    if ((arr[i] + arr[j]) == k)
                        count++;
            return count;
        }

        public static string RotationalCipher(string input, int rotationFactor)
        {
            StringBuilder result = new StringBuilder();

            foreach (var ch in input)
            {
                if (char.IsDigit(ch))
                {
                    var ch1 = ((char.GetNumericValue(ch) + rotationFactor) % 10).ToString(CultureInfo.InvariantCulture);
                    result.Append(ch1);
                }
                else if (char.IsLetter(ch))
                {

                    if (char.IsUpper(ch))
                    {
                        var ch1 = (char)(((int)ch + rotationFactor - 65) % 26 + 65);
                        result.Append(ch1);
                    }
                    else
                    {
                        var ch1 = (char)(((int)ch +
                                        rotationFactor - 97) % 26 + 97);
                        result.Append(ch1);
                    }
                }
                else
                {
                    var ch1 = (char)(((int)ch));
                    result.Append(ch1);
                }
            }
            return result.ToString();
        }

        public static int[] CountSubarrays(int[] arr)
        {
            var answer = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                var count = 1;
                var localMax = arr[i];
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < localMax)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                for (var k = i - 1; k >= 0; k--)
                {
                    if (arr[k] < localMax)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                answer[i] = count;
            }
            return answer;
        }
    }
}

