
namespace CarShop.Data.Context;

public class CarShopContext(DbContextOptions<CarShopContext> builder) : DbContext(builder)
{
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Filter> Filters => Set<Filter>();
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Model> Models => Set<Model>();
    public DbSet<Manufacturer> Manufacturers => Set<Manufacturer>();
    public DbSet<CarBrand> CarBrands => Set<CarBrand>();
    public DbSet<CarColor> CarColors => Set<CarColor>();
    public DbSet<CarFilter> CarFilters => Set<CarFilter>();
    public DbSet<CarManufacturer> CarManufacturers => Set<CarManufacturer>();
    public DbSet<CarModel> CarModels => Set<CarModel>();
    public DbSet<CarProductionYear> CarProductionYears => Set<CarProductionYear>();
    public DbSet<Mileage> MileageOfCars => Set<Mileage>();
    public DbSet<Price> PriceOfCars => Set<Price>();
    public DbSet<ProductionYear> ProductionYears => Set<ProductionYear>();


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Composite Keys
        builder.Entity<CarBrand>()
            .HasKey(cb => new { cb.CarId, cb.BrandId });
        builder.Entity<CarColor>()
            .HasKey(cc => new { cc.CarId, cc.ColorId });
        builder.Entity<CarFilter>()
            .HasKey(cf => new { cf.CarId, cf.FilterId });
        builder.Entity<CarManufacturer>()
            .HasKey(cm1 => new { cm1.CarId, cm1.ManufacturerId });
        builder.Entity<CarMileage>()
            .HasKey(cm2 => new { cm2.CarId, cm2.MileageId });
        builder.Entity<CarModel>()
            .HasKey(cm3 => new { cm3.CarId, cm3.ModelId });
        builder.Entity<CarPrice>()
            .HasKey(cp => new { cp.CarId, cp.PriceId });
        builder.Entity<CarProductionYear>()
            .HasKey(cpy => new { cpy.CarId, cpy.ProductionYearId });
        #endregion

        #region CarBrand Many-to-Many Relationship

        builder.Entity<Car>()
            .HasMany(c => c.Brands)
            .WithMany(b => b.Cars)
            .UsingEntity<CarBrand>();
        #endregion

        #region CarColor Many-to-Many Relationship
        builder.Entity<Car>()
            .HasMany(c => c.Colors)
            .WithMany(c => c.Cars)
            .UsingEntity<CarColor>();
        #endregion

        #region CarFilter Many-to-Many Relationship
        builder.Entity<Car>()
            .HasMany(c => c.Filters)
            .WithMany(f => f.Cars)
            .UsingEntity<CarFilter>();
        #endregion

        #region CarManufacturer Many-to-Many Relationship
        builder.Entity<Car>()
            .HasMany(c => c.Manufacturers)
            .WithMany(m => m.Cars)
            .UsingEntity<CarManufacturer>();
        #endregion

        #region CarMileage Many-to-Many Relationship
        builder.Entity<Car>()
            .HasMany(c => c.Mileages)
            .WithMany(m => m.Cars)
            .UsingEntity<CarMileage>();
        #endregion

        #region CarModel Many-to-Many Relationship
        builder.Entity<Car>()
            .HasMany(c => c.Models)
            .WithMany(m => m.Cars)
            .UsingEntity<CarModel>();
        #endregion

        #region CarPrice Many-to-Many Relationship
        builder.Entity<Car>()
            .HasMany(c => c.Prices)
            .WithMany(p => p.Cars)
            .UsingEntity<CarManufacturer>();
        #endregion

        #region CarProductionYear Many-to-Many Relationship
        builder.Entity<Car>()
            .HasMany(c => c.ProductionYears)
            .WithMany(py => py.Cars)
            .UsingEntity<CarManufacturer>();
        #endregion
    }


}
