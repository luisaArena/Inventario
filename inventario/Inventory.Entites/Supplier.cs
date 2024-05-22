
namespace Inventory.Entites
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime updateAt {get; set;}

        public IEnumerable<Product>? Products {get; set;}

    }
}