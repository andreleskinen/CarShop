

namespace CarShop.Data.Entities;

public class Mileage : IEntity
{
    public int Id { get; set; }
    public int MileageOfCar { get; set; }
    public List<Car> Cars { get; set; }

}

