
namespace Inventory.Entites
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Barcode { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime updateAt {get; set;}

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier {get; set;}

        public IEnumerable<InventoryMovement>? InventoryMovements {get; set;}

    }
}