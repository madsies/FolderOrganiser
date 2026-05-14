using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOrganiser.Models
{
    public class FOFile
    {
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Extension { get; set; } = string.Empty;
        public DateTime TimeCreated { get; set; }
        public DateTime LastEdited  { get; set; }
        public int FileSize { get; set; }
    }
}
