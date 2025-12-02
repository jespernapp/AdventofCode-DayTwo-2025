namespace AdventofCode_DayTwo_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var csvData = CsvReader.ReadCsv("OrderIds.csv");
            foreach (var item in csvData)
            {
                Console.WriteLine(item);
            }
            IdComparer.Check(csvData);
        }
    }
}
