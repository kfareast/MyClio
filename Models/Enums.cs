using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeManagement.Models
{
    public enum CaseStatus
    {
        [Description("Đang xử lý")]
        Open = 0,
        [Description("Hoàn thành")]
        Closed = 1
    }

    public enum TaskStatus
    {
        [Description("Đang xử lý")]
        Pending = 0,
        [Description("Hoàn thành")]
        Completed = 1
    }
}
