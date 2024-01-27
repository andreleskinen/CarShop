using System;
namespace CarShop.Data.Entities;

public class Category : IEntity
{
    public int CatergoryId { get; set; }
    public string Name { get; set; }

    public List<Car> Cars { get; set; }
}

