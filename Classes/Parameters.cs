using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Parameters
    {
        public string? query { get; set; }
        public int? page { get; set; }
        public int? num_pages { get; set; }
        public string? date_posted { get; set; }
        public string? country { get; set; }
        public string? language { get; set; }
    }
}
