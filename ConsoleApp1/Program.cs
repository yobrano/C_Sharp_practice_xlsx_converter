using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourceFile = "D:\\userData\\Development\\Development\\Tutorials\\C-Sharp-csv\\ConsoleApp1\\ConsoleApp1\\play.xlsx";
            string destFile = "D:\\userData\\Development\\Development\\Tutorials\\C-Sharp-csv\\ConsoleApp1\\ConsoleApp1\\Payment.csv";

            var cvt = new XLSXConverter();
            cvt.convertFile(sourceFile, destFile);
        }
    }
}
