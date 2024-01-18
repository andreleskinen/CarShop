

namespace CarShop.Data.Entities;

public class Mileage : IEntity
{
    public int MileageId { get; set; }
    public int MileageOfCar { get; set; }
    public List<Car> Cars { get; set; }

}

