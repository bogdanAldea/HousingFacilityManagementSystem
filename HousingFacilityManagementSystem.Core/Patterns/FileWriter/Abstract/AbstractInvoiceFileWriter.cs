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
        
        public string GetFileName() 
        { 
            return $"invoice-{_data.Number}-{_data.ApartmentId}{_data.Id}";
        }

        public string GetPath(string filename) 
        {
            string fullFilename = $"{filename}.{_extension}";
            string path =  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), _dirName);
            Directory.CreateDirectory(path);
            return Path.Combine(path, fullFilename);

        }
        public void WriteFile()
        {
            string filename = GetFileName();
            string path = GetPath(filename);
            string formattedData = FormatInvoiceTemplate(_data);
            PopulateFile(formattedData, path);
        }

    }
}
