using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvHelperDemo
{
    public class Employee
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public string Name { get; set; }

        [Index(2)]
        public DateTime Birthday { get; set; }
    }
}
