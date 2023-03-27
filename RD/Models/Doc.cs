using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Doc
    {
        public int Id { get; set; }
        //public int ScientificDocId { get; set; }
        public int ThemeId { get; set; }
        public string Path { get; set; }
        public string? InventoryNum { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? DocType { get; set; }
        public string? Designation { get; set; }
        public string? NameDoc { get; set; }
        public string? NumStateReg { get; set; }
        public string? ExecutiveDepartment { get; set; }
        public string? FioManager { get; set; }
        public string? ResponsiblePerson { get; set; }
        public int? SheetNumber { get; set; }
        public int? NumCopies { get; set; }
        public string? WhoPassed { get; set; }
        public string? WhoAccepted { get; set; }
        public string? Note { get; set; }

        public Doc(int id, string? nameDoc)
        {
            Id = id;
            NameDoc = nameDoc;
        }

        public Doc(int id, string? nameDoc, string docType)
        {
            Id = id;
            NameDoc = nameDoc;
            DocType = docType;
        }


        public Doc()
        {
        }
    }
}
