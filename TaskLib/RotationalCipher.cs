using System;
using System.Text;

namespace TaskLib
{
    public class RotationalCipher
    {

        public static string rotationalCipher(String input, int rotationFactor)
        {
            StringBuilder result = new StringBuilder();
                       
            foreach(var ch in input)
            {
                if (char.IsDigit(ch))
                {                  
                    var ch1 = ((char.GetNumericValue(ch) + rotationFactor) % 10).ToString();
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
    }
}
