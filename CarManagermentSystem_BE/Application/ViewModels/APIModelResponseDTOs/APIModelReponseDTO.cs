namespace Application.ViewModels.APIModelResponseDTOs
{
    public class APIModelReponseDTO
    {
        public int? Code { get; set; } 
        public string? Message { get; set; } = string.Empty;
        public List<string>? ErrorMessages { get; set; } = new List<string>();
        public bool? IsSuccess { get; set; } = false;
        public object? Data { get; set; }
    }
}
