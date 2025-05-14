using RestSharp;
using Newtonsoft.Json;
using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var apiHit = new RestClient("https://jsearch.p.rapidapi.com/search?query=software%20developer&page=10&num_pages=10&country=za&date_posted=all");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("x-rapidapi-key", "its a secret :D, nice try  :D");
            request.AddHeader("x-rapidapi-host", "jsearch.p.rapidapi.com");

            Console.WriteLine("Loading...");

            try
            {
                var restResponse = await apiHit.ExecuteAsync(request);
                
                if (restResponse.IsSuccessful)
                {
                    var response = JsonConvert.DeserializeObject<Response>(restResponse.Content);

                    Console.Clear();
                    if (response?.data != null && response.data.Count > 0)
                    {
                        Console.WriteLine($"Job count: {response.data.Count}");
                        Console.WriteLine();

                        foreach (var item in response.data)
                        {
                            Console.WriteLine($"Job Title: {item.job_title ?? "N/A"}");
                            Console.WriteLine($"Job ID: {item.job_id ?? "N/A"}");
                            Console.WriteLine($"Employer: {item.employer_name ?? "N/A"}");
                            Console.WriteLine($"Location: {item.job_location ?? "N/A"}");
                            Console.WriteLine($"Employment Type: {item.job_employment_type ?? "N/A"}");
                            Console.WriteLine($"Salary: {item.job_salary ?? "N/A"}");
                            Console.WriteLine($"Min Salary: {item.job_min_salary ?? "N/A"}");
                            Console.WriteLine($"Max Salary: {item.job_max_salary ?? "N/A"}");
                            Console.WriteLine($"Publisher: {item.job_publisher ?? "N/A"}");
                            Console.WriteLine($"Apply Link: {item.job_apply_link ?? "N/A"}");
                            Console.WriteLine($"Posted: {item.job_posted_at ?? "N/A"}");
                            Console.WriteLine($"Remote: {(item.job_is_remote ? "Yes" : "No")}");

                            Console.WriteLine("Job Res: ");
                            if (item?.job_highlights?.Responsibilities != null)
                            { 
                                foreach(var newItem in item.job_highlights.Responsibilities) 
                                {
                                    Console.WriteLine($"-{newItem}");
                                }
                            }

                            Console.WriteLine("Job Qual: ");
                            if (item?.job_highlights?.Qualifications != null)
                            {
                                foreach (var newItem in item.job_highlights.Qualifications)
                                {
                                    Console.WriteLine($"-{newItem}");
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine("-------------------");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("null");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Status code: {restResponse.StatusCode}");
                    Console.WriteLine($"Error: {restResponse.ErrorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}