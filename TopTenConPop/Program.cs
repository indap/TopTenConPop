using System;

namespace TopTenConPop
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\punin\source\repos\TopTenConPop\worldpops.csv";
            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
