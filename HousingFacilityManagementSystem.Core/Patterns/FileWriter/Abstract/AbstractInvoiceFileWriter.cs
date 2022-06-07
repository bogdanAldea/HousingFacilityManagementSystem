using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Core.Patterns.FileWriter.Abstract
{
    public abstract class AbstractInvoiceFileWriter
    {

        private readonly Invoice _data;
        private readonly string _extension;
        private readonly string _dirName = "Housing Facility CMS";

        public AbstractInvoiceFileWriter(Invoice data, string extension)
        {
            _data = data;
            _extension = extension;
        }

        public abstract string FormatInvoiceTemplate(Invoice invoice);
        public abstract void PopulateFile(string formattedData, string path);
        
        public string SetFileName() 
        { 
            return $"invoice-{_data.Number}-{_data.ApartmentId}{_data.Id}";
        }

        public string SetPath(string filename) 
        {
            string fullFilename = $"{filename}.{_extension}";
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), _dirName, fullFilename);

        }
        public void WriteFile()
        {
            string filename = SetFileName();
            string path = SetPath(filename);
            string formattedData = FormatInvoiceTemplate(_data);
            PopulateFile(formattedData, path);
        }

    }
}
