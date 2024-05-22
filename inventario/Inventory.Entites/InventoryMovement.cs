namespace Inventory.Entites
{
    public class InventoryMovement
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public int quantity { get; set; }

        public int MovementTypeId { get; set; }

        public  MovementType? MovementType { get; set; }

        public int ProductId { get; set; }

        public Product? Products { get; set;}


    }
}