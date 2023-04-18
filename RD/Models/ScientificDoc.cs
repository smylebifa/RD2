using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class ScientificDoc
    {
        public int Id { get; set; }
        public int StageId { get; set; }
        
        // Предмет (уточнение)
        public string? Name { get; set; }
        public string? Result { get; set; }
        public string? Location { get; set; }
        public string? Note { get; set; }

        public ScientificDoc(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public ScientificDoc(int id, string? name, string? result)
        {
            Id = id;
            Name = name;
            Result = result;
        }

        public ScientificDoc()
        {
        }
    }
}
