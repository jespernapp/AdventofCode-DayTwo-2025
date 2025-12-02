using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode_DayTwo_2025
{
    public class CsvReader
    {
        public static List<string> ReadCsv(string filePath)
        {
            try
            {
                var ranges = File.ReadAllText(filePath).Split(',').ToList();
                return ranges;
            }
            catch (Exception ex)
            {

                throw new Exception($"Error reading CSV file: {ex.Message}");
            }
        }
    }
}