using System;

namespace ExtractFile
{
    class ExtractFile
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            int indexOfLastSlash = filePath.LastIndexOf('\\');
            int indexOfFileExtension = filePath.LastIndexOf('.');
            int fileNameLenght = indexOfFileExtension - indexOfLastSlash - 1;
            var fileName = filePath.Substring(indexOfLastSlash + 1, fileNameLenght);
            var fileExtension = filePath.Substring(indexOfFileExtension + 1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}
