using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Patterns.FileWriter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Patterns.FileWriter.Concrete
{
    public class TxtInvoiceFileWriter : AbstractInvoiceFileWriter
    {
        public TxtInvoiceFileWriter(Invoice data, string extension) : base(data, extension) {}

        public override string FormatInvoiceTemplate(Invoice invoice)
        {
            return $"Invoice number {invoice.Number}\n" +
                   $"---------------------------------------\n" +
                   $"Issued on: {invoice.IssueDate}\n" +
                   $"Amount to pay: {invoice.Payment}\n" +
                   $"Paid: {(invoice.IsPaid ? "Yes" : "No")}";
        }

        public override void PopulateFile(string formattedData, string path)
        {
            FileStream filstream = File.Create(path);
            using (StreamWriter steamWriter = new StreamWriter(filstream))
            {
                steamWriter.WriteLine(formattedData);
            }
        }
    }
}
