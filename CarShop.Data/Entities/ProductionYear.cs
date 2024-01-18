

namespace CarShop.Data.Entities;

public class ProductionYear : IEntity
{
    public int ProductionYearId { get; set; }
    public int Year { get; set; }
    public List<Car> Cars { get; set; }

}

