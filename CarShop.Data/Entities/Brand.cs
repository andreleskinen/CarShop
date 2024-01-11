using CarShop.Data.Shared.Interfaces;

namespace CarShop.Data.Entities;

public class Brand : IEntity
{
    public int BrandId { get; set; }
    public string BrandName { get; set; }
}

