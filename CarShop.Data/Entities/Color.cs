

using CarShop.Data.Entities;

namespace CarShop.Data;

public class Color : IEntity
{
    public int ColorId { get; set; }
    public string ColorName { get; set; }
    public List<Car> Cars { get; set; }

}

