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
            foreach (var id in ids)
            {
                try
                {
                    var parts = id.Split('-');
                    long idStart = long.Parse(parts[0]);
                    long idEnd = long.Parse(parts[1]);
                    for (long i = idStart; i <= idEnd; i++)
                    {
                        Console.WriteLine($"Comparing ID: {i}");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error comparing IDs: {ex.Message}");
                }
            }
        }
    }
}
