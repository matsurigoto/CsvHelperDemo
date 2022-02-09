using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CsvHelperDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Read Section
            var readConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            using (var reader = new StreamReader("Employee.csv"))
            using (var csv = new CsvReader(reader, readConfiguration))
            {
                var records = csv.GetRecords<Employee>();

                foreach (var employee in records)
                {
                    Console.WriteLine(employee.Name + "," + employee.Birthday);
                }
            }


            //Write Section
            var writeRecords = new List<Employee>
            {
             new Employee { Id = 1, Name = "Ina", Birthday=DateTime.Now },
             new Employee { Id = 2, Name = "Duran", Birthday=DateTime.Now},
            };

            var writeConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var writer = new StreamWriter("Result.csv"))
            using (var csv = new CsvWriter(writer, writeConfiguration))
            {
                csv.WriteRecords(writeRecords);
            }
        }
    }
}
