using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeManagement.Models
{
    public class CaseFile
{
    public int CaseFileId { get; set; }      
    public string Title { get; set; }           
    public DateTime ReceivedDate { get; set; }   
    public CaseStatus Status { get; set; }      

    public int ClientId { get; set; }           
    public Client Client { get; set; }           
    public ICollection<WorkLog> WorkLogs { get; set; }
    public ICollection<Document> Documents { get; set; }

    public CaseFile()
    {
        WorkLogs = new List<WorkLog>();
        Documents = new List<Document>();
    }
}
}
