using Microsoft.AspNetCore.Http;

namespace API.Models
{
    public class DataFileVm
    {
        public int IdTenant { get; set; }
        public IFormFile File { get; set; }
    }
}
