using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeManagement.Models
{
    public class Document
    {
        public int DocumentId { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CaseFileId { get; set; }
        public CaseFile CaseFile { get; set; }
    }
}
