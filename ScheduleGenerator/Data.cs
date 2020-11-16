using Bogus;
using System.Collections.Generic;

namespace ScheduleGenerator
{
    public class Data
    {
        public string ProfesorName { get; set; }
        public string Class { get; set; }
        public string Classroom { get; set; }
        public int Duration { get; set; }
        public static Faker<Data> FakeData { get; } =
            new Faker<Data>()
                .RuleFor(d => d.ProfesorName, f => f.Name.FullName())
                .RuleFor(d => d.Class, f => f.PickRandom(classes))
                .RuleFor(d => d.Duration, f => f.PickRandom(classDuration))
                .RuleFor(d => d.Classroom, f => f.PickRandom(classroomNumber).ToString() + f.PickRandom(classroomLetter));

        private static List<string> classes = new List<string>() { "programming", "mathematic", "object oriented programming", "data bases", "logical thinking" };
        private static List<int> classDuration = new List<int>() { 2, 3, 4 };
        private static List<int> classroomNumber = NumberGenerate();
        private static List<char> classroomLetter = LetterGenerate();

        private static List<int> NumberGenerate()
        {
            var x = new List<int>();
            for (int i = 1; i < 30; i++)
                x.Add(i);

            return x;
        }

        private static List<char> LetterGenerate()
        {
            var x = new List<char>();
            for (int i = 0; i < 5; i++)
                x.Add((char)('A' + i));

            return x;
        }
    }
}
