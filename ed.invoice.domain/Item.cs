namespace ed.invoice.domain
{
    public class Item : DomainBase
    {
        public Item()
        {
        }

        public string Name { get; set; }
        public decimal CurrentPrice { get; set; }

    }
}
