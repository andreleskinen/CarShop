﻿

namespace CarShop.Data.Entities;

public class Model : IEntity
{
    public int Id { get; set; }
    public string ModelName { get; set; }
    public List<Car> Cars { get; set; }

}

