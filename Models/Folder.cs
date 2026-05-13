using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderOrganiser.Models
{
    class FOFolder
    {
        public string Name { get; set; } = string.Empty;
        public FOFile[] Files {get;set;} = Array.Empty<FOFile>();
    }
}
