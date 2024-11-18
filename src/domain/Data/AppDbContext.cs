using Microsoft.EntityFrameworkCore;
using numi.src.domain.Models;

namespace numi.src.domain.Data;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=numi.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasData(
            new Category() {Id = "001", Name = "Dreamy" },
            new Category() {Id = "002", Name = "Sky" },
            new Category() {Id = "003", Name = "Sky Pillowtop" },
            new Category() {Id = "004", Name = "Aqua Memory" },
            new Category() {Id = "005", Name = "Calma" }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product() {Id = "01010010001", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010010002", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010010003", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010010004", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010010005", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010010006", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010010007", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010010008", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010010009", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010020001", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010020002", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010020003", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010020004", Name = "", Description = "", Dimension = "", CategoryId = "" },
            new Product() {Id = "01010020005", Name = "", Description = "", Dimension = "", CategoryId = "" }

            );
    }
}