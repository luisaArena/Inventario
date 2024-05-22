
namespace Inventory.Entites
{
    public class InventoryStock
    {
        public int Id { get; set; }
        
        public int quantity { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime updateAt {get; set;}

        public int ProductId { get; set; }

        public Product? Products { get; set;}

    }
}