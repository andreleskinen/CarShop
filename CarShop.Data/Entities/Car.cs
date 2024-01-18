

namespace CarShop.Data.Entities;

public class Car : IEntity
{
    public int CarId { get; set; }
    public List<Color> Colors { get; set; }
    public List<Manufacturer> Manufacturers { get; set; }
    public List<ProductionYear> ProductionYears { get; set; }
    public List<Brand> Brands { get; set; }
    public List<Price> Prices { get; set; }
    public List<Filter> Filters { get; set; }
    public List<Mileage> Mileages { get; set; }
    public List<Model> Models { get; set; }
}

