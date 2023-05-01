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
        public string? FileType { get; set; }
        public string Path { get; set; }

        public File()
        {
        }

        public File(int id, string? filename)
        {
            Id = id;
            Filename = filename;
        }

        ////public File(string? filename)
        ////{
        ////    Filename = filename;
        ////}


        public File(int id, string? filename, string path)
        {
            Id = id;
            Filename = filename;
            Path = path;
        }

        public File(int id, string? filename, string path, string fileType)
        {
            Id = id;
            Filename = filename;
            Path = path;
            FileType = fileType;
        }

    }
}
