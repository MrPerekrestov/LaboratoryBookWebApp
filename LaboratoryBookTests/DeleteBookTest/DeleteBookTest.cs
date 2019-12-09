using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace LaboratoryBookTests.DeleteBookTest
{
    public static class DeleteBookTest
    {
       public static string GetDeleteBookCommandString()
        {
            var assembly = Assembly.GetCallingAssembly();                  
            var resourseStream = assembly.GetManifestResourceStream("LaboratoryBookTests.DeleteBookTest.DeleteLaboratoryBookTemplate.txt");

            var deleteLaboratoryBookString = string.Empty;

            using (var streamRead = new StreamReader(resourseStream))
            {
                deleteLaboratoryBookString = streamRead.ReadToEnd();
            }

            return deleteLaboratoryBookString;
        }

        public static string SetProperLaboratoryBookNameAndId(
            string deleteLaboratoryBookCommand,
            string laboratoryBookName,
            int laboratoryBookId)
        {
            return deleteLaboratoryBookCommand
                    .Replace("[NewLaboratoryBookId]", laboratoryBookId.ToString())
                    .Replace("test_db", laboratoryBookName);
        }
    }
}
