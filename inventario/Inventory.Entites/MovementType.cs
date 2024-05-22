
namespace Inventory.Entites
{
    public class MovementType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Descripcion { get; set; }

        public bool IsIncoming { get; set; }

        public bool IsOutgoing { get; set; }
        public bool IsInternalTransfer { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime updateAt {get; set;}

        public IEnumerable<InventoryMovement>? InventoryMovements {get; set;}
    }
}