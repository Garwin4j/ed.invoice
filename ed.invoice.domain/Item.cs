using MongoRepository;

namespace ed.invoice.domain
{
    public class Item : Entity
    {
        public Item()
        {
        }

        public string Name { get; set; }
        public decimal CurrentPrice { get; set; }

    }
}
