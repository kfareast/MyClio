using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeManagement.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string FullName { get; set; }

        public string? Phone { get; set; }

        public string? Note { get; set; }

        public ICollection<CaseFile> CaseFiles { get; set; }
    }
}
