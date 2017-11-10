namespace ed.invoice.application.Customer
{
    public interface IPagedQueryRequest
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}