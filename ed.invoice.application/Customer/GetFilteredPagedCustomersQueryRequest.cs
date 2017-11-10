namespace ed.invoice.application.Customer
{
    public class GetFilteredPagedCustomersQueryRequest : IPagedQueryRequest
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public string FirstNameFilter { get; set; }
    }
}