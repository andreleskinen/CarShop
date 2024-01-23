

namespace CarShop.Data.Entities;

public class ProductionYear : IEntity
{
    public int Id { get; set; }
    public int Year { get; set; }
    public List<Car> Cars { get; set; }

}

