namespace RopodApp.Shared.Models
{
    public class PaginatedResult<T>
    {
        public List<T> Data { get; set; } = new();
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }

        public PaginatedResult()
        {
        }

        public PaginatedResult(List<T> data, int pageNumber, int pageSize, int totalRecords)
        {
            Data = data;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalRecords = totalRecords;
            TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            HasNextPage = pageNumber < TotalPages;
            HasPreviousPage = pageNumber > 1;
        }

        public static PaginatedResult<T> CreateAsync(List<T> source, int pageNumber, int pageSize, int totalCount)
        {
            return new PaginatedResult<T>(source, pageNumber, pageSize, totalCount);
        }
    }
}
