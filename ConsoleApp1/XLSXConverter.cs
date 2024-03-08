using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using System.Runtime.InteropServices;


namespace ConsoleApp1
{
    public class XLSXConverter
    {
        public void convertFile(string srcFile, string destFiles)
        {
            string destFile = "C:\\Users\\Brian\\Desktop\\New folder\\ConsoleApp1\\ConsoleApp1\\Hello.csv";
            string destFile2 = "C:\\Users\\Brian\\Desktop\\New folder\\ConsoleApp1\\ConsoleApp1\\Hellos.csv";
            // read file by passing in a password if required.
            // convert it to csv with delimeter ","
            // convert it to csv with delimeter "|"

            var streamOut = new StreamWriter(srcFile);

            Excel.Application excelApplication = new Excel.Application();
            Console.WriteLine("Reading File.");

            
            Excel.Workbook excelWorkBook = excelApplication.Workbooks.Open("C:\\Users\\Brian\\Desktop\\New folder\\ConsoleApp1\\ConsoleApp1\\Hello.xlsx");
            excelWorkBook.SaveAs(destFile, Excel.XlFileFormat.xlCSV);
            Console.WriteLine("Initial CSV file (comma)");

            excelWorkBook.Close();

            excelApplication.Quit();
            Console.WriteLine("Instance Closed...");

            Marshal.ReleaseComObject(excelWorkBook);
            Marshal.ReleaseComObject(excelApplication);

            using (var reader = new StreamReader(destFile))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                var records = csv.GetRecords<FileStructure>();
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = "|"
                };

                Console.WriteLine("editing comma to pipe, done...");

                using (StreamWriter writer = new StreamWriter(destFile2))
                {

                    using (CsvWriter csvWriter = new CsvWriter(writer, config))
                    {
                        csvWriter.WriteRecords(records);
                    }
                }
            }
            Console.WriteLine("Posterior CSV file (pipe)");

            Console.WriteLine("Done...File was converted successfully.");


        }
    }
}
