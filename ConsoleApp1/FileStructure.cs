using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileStructure
    {
        [Name("Record_Identifier")]
        public string Record_Identifier { get; set; }
        [Name("Customer_Code")]
        public string Customer_Code { get; set; }
        [Name("Debit_Account_No")]
        public string Debit_Account_No { get; set; }
        [Name("Payment_Amount")]
        public string Payment_Amount { get; set; }
        [Name("Payment_Value_Date")]
        public string Payment_Value_Date { get; set; }
        [Name("Payment_Product_Code")]
        public string Payment_Product_Code { get; set; }
        [Name("Credit_Account_No")]
        public string Credit_Account_No { get; set; }
        [Name("Credit_Branch_Code")]
        public string Credit_Branch_Code { get; set; }
        [Name("Beneficiary_Code")]
        public string Beneficiary_Code { get; set; }
        [Name("Beneficiary_Name")]
        public string Beneficiary_Name { get; set; }
        [Name("Payment_Currency_Code")]
        public string Payment_Currency_Code { get; set; }
        [Name("Customer_Reference_No")]
        public string Customer_Reference_No { get; set; }

  }
}
