using Newtonsoft.Json;
using System;
using System.Linq;

namespace ScheduleGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var testData = Data.FakeData.Generate(5).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData,
                Formatting.Indented));
        }
    }
}
