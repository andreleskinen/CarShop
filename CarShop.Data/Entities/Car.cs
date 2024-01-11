

namespace CarShop.Data.Entities;

public class Car : IEntity
{
    public int CarId { get; set; }
    public Color Color { get; set; }
    public Manufacturer Manufacturer { get; set; }
    public ProductionYear ProductionYear { get; set; }
    public Brand Brand { get; set; }
}

