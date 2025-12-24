using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeManagement.Models
{
    public class WorkLog
    {
        public int WorkLogId { get; set; }
        public string? Title { get; set; }        
        public DateTime Date { get; set; }      
        public TaskStatus Status { get; set; }

        public int CaseFileId { get; set; }     
        public CaseFile CaseFile { get; set; }    

    }
}
