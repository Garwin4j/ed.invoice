namespace ed.invoice.domain
{
    public class LineItem : DomainBase
    {
        public LineItem()
        {
        }

        public Item Item { get; set; }
        public int Count   { get; set; }

    }
}
