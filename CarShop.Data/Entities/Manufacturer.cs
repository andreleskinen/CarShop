

namespace CarShop.Data.Entities;

public class Manufacturer : IEntity
{
    public int ManufacturerId { get; set; }
    public string ManufacturerName { get; set; }
    public List<Car> Cars { get; set; }
}

