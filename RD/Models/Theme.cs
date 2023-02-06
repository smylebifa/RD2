using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
        public string? FioManager { get; set; }
        public string? ExecutiveDepartment { get; set; }
        public string? CustomerName { get; set; }
        public int? CustomerId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? WorkStart { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? WorkEnd { get; set; }
       
        public int? Amount { get; set; }
        public int? Vat { get; set; }
        public int? AmountWithoutVat { get; set; }
        public string? Decree { get; set; }
        public string? DocType { get; set; }
        public string? Props { get; set; }
        public string? ResearchType { get; set; }
        public string? Knowledge { get; set; }
        public string? Status { get; set; }
        
        //public DateTime? CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }

        public Theme(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public Theme()
        {
            //Id = Guid.NewGuid();
        }
    }
}
