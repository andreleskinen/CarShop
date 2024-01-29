using System;
namespace CarShop.Data.Entities;

public class Category : IEntity
{
    public int CategoryId { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Car> Cars { get; set; }
}

