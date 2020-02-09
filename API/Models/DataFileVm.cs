using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class DataFileVm
    {
        public int IdTenant { get; set; }
        public IFormFile file { get; set; }
    }
}
