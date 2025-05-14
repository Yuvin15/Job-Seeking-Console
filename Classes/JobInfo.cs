using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class JobInfo
    {
        public string? job_id { get; set; } 
        public string? job_title { get; set; }
        public string? employer_name { get; set; }
        public string? employer_logo { get; set; }
        public string? employer_website { get; set; }
        public string? job_publisher { get; set; }
        public string? job_employment_type { get; set; }
        public List<string>? job_employment_types { get; set; }
        public string? job_apply_link { get; set; }
        public bool job_apply_is_direct { get; set; }
        public dynamic? apply_options { get; set; }
        public string? job_description { get; set; }
        public bool job_is_remote { get; set; }
        public string? job_posted_at { get; set; }
        public long? job_posted_at_timestamp { get; set; }
        public string? job_posted_at_datetime_utc { get; set; }
        public string? job_location { get; set; }
        public string? job_city { get; set; }
        public string? job_state { get; set; }
        public string? job_country { get; set; }
        public double? job_latitude { get; set; }
        public double? job_longitude { get; set; }
        public dynamic? job_benefits { get; set; }
        public string? job_google_link { get; set; }
        public string? job_salary { get; set; }
        public string? job_min_salary { get; set; }
        public string? job_max_salary { get; set; }
        public string? job_salary_period { get; set; }
        public JobDesc? job_highlights { get; set; }
        public string? job_onet_soc { get; set; }
        public string? job_onet_job_zone { get; set; }
    }
}
