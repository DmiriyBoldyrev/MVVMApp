using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    internal class PageModel
    {
        public int IdEmp { get; set; }
        public int IdWoeker { get; set; }
        public string NameEmp { get; set; }
        public string NameWorker { get; set; }
        public int age { get; set; }
        public int exp { get; set; }
        public string emailWorker { get; set; }
        public string emailEmp { get; set; }
        public bool status { get; set; }
        public string gender { get; set; }
    }
}
