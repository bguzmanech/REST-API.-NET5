using System.Collections.Generic;


namespace Catalogo.Repositorio

{
    public class ElementosDeMemoriaRepositorio 
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Nombre = "Potion", Precio = 9, FechaDeCreacion = DateTimeOffset.UtcNow},
            new Item { Id = Guid.NewGuid(), Nombre = "Iron Sowrd", Precio = 20, FechaDeCreacion = DateTimeOffset.UtcNow},
            new Item { Id = Guid.NewGuid(), Nombre = "Bronze Shield", Precio = 18, FechaDeCreacion = DateTimeOffset.UtcNow}          
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }
    }
    
}