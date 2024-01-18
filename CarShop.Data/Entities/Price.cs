

namespace CarShop.Data.Entities;

public class Price : IEntity
{
    public int PriceId { get; set; }
    public int PriceOfCar { get; set; }
    public List<Car> Cars { get; set; }

}

