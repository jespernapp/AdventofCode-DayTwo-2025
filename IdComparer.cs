using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode_DayTwo_2025
{
    public class IdComparer
    {
        public static void Check(List<string> ids)
        {
            long invalidSum = 0;
            foreach (var id in ids)
            {
                try
                {
                    var parts = id.Split('-');
                    long idStart = long.Parse(parts[0]);
                    long idEnd = long.Parse(parts[1]);
                    for (long i = idStart; i <= idEnd; i++)
                    {
                        string number = i.ToString();
                        int numberLength = number.Length;
                        for (int len = 1; len <= numberLength / 2; len++)
                        {
                            if (numberLength % len != 0) continue;
                            string pattern = number.Substring(0, len);
                            bool isRepeating = true;
                            for (int j = len; j < numberLength; j += len)
                            {
                                if (number.Substring(j, len) != pattern)
                                {
                                    isRepeating = false;
                                    break;
                                }
                            }
                            if (isRepeating)
                            {
                                invalidSum += i;
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error comparing IDs: {ex.Message}");
                }
            }
            Console.WriteLine($"Sum of invalid IDs: {invalidSum}");
        }
    }
}
