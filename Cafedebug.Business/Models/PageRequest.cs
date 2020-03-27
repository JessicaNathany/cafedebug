namespace Cafedebug.Business.Models
{
    public class PageRequest
    {
        public int Page { get; set; } = 1;
        public int ItemsPerPage { get; set; } = 10;
        public string SortBy { get; set; } = "Id";
        public SortDirection SortDirection { get; set; }
    }
}
