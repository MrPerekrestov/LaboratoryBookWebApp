using System;
using LaboratoryBookTests.DeleteBookTest;

namespace LaboratoryBookTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = DeleteBookTest.DeleteBookTest.GetDeleteBookCommandString();
            Console.WriteLine(str);
            Console.WriteLine();
            var newStr = DeleteBookTest.DeleteBookTest.SetProperLaboratoryBookNameAndId(
                str,
                "NewName",
                1);
            Console.WriteLine(newStr);
            Console.ReadKey();
        }
    }
}
