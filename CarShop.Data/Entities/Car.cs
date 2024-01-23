

namespace CarShop.Data.Entities;

public class Car : IEntity
{
    public int Id { get; set; }
    public List<Color> Colors { get; set; }//1-många
    public List<Manufacturer> Manufacturers { get; set; }//1-många
    public List<ProductionYear> ProductionYears { get; set; }//int
    public List<Brand> Brands { get; set; }
    public List<Price> Prices { get; set; }//double
    public List<Filter> Filters { get; set; }
    public List<Mileage> Mileages { get; set; }//int
    public List<Model> Models { get; set; }
}

