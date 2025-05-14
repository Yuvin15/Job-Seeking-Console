using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Response
    {
        public string? status { get; set; }
        public string? request_id { get; set; }
        public Parameters? parameters { get; set; }
        public List<JobInfo>? data { get; set; }
    }
}
