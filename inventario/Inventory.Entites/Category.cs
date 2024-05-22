
namespace Inventory.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime updateAt {get; set;}

        public IEnumerable<Product>? Products {get; set;}

    }
}