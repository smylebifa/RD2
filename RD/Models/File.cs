using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class File
    {
        public int Id { get; set; }
        public int? EntityId { get; set; }
        public string? Filename { get; set; }
        public string? EntityType { get; set; }
        
        public File(int id, string? filename)
        {
            Id = id;
            Filename = filename;
        }

        public File(int id, string? filename, string? entityType)
        {
            Id = id;
            Filename = filename;
            EntityType = entityType;
        }

        public File()
        {
            //Id = Guid.NewGuid();
        }
    }
}
