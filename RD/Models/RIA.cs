using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class RIA
    {
        public int Id { get; set; }
        public int StageId { get; set; }
        public string? Result { get; set; }
        public string? Props { get; set; }
        public string? Authors { get; set; }
        public string? Location { get; set; }

        public RIA(int id, string? result)
        {
            Id = id;
            Result = result;
        }

        public RIA(int id, string? result, string? props, string? authors, string? location)
        {
            Id = id;
            Result = result;
            Props = props;
            Authors = authors;
            Location = location;
        }

        public RIA()
        {
            //Id = Guid.NewGuid();
        }
    }
}
