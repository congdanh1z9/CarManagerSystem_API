using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.APIModelResponseDTOs
{
    public class APIModelReponseDTO<T>
    {
        public int? Code { get; set; } 
        public string? Message { get; set; } = string.Empty;
        public List<string>? ErrorMessages { get; set; } = new List<string>();
        public bool? IsSuccess { get; set; } = false;
        public T? Data { get; set; }
    }
}
