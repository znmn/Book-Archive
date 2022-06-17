using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    internal static class FileHelper
    {
        public static string basePath = Directory.GetCurrentDirectory() + @"\book\";
        
        public static string getFileName(this string path)
        {
            string[] arr = path.Split('\\');
            return arr[arr.Length - 1];
        }

        public static string[] generatePdfPath()
        {
            string fileName = RandomString(7) + ".pdf";
            return new string[] { fileName, basePath + fileName};
        }

        public static string pdfNametoPath(this string pdfFile)
        {
            return basePath + pdfFile;
        }

        public static void deletePdf(this string pdfFile)
        {
            File.Delete(basePath + pdfFile);
        }

            public static string RandomString(this int length)
        {
            Random rand = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}
