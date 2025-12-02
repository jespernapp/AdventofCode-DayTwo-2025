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
                        if (i.ToString().Length % 2 == 0)
                        {
                            string number = i.ToString();
                            int mid = number.Length / 2;
                            long first = long.Parse(number.Substring(0, mid));
                            long second = long.Parse(number.Substring(mid, mid));
                            if (first == second)
                            {
                                invalidSum += i;
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
