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
            new Category() {CategoryId = "001", Name = "Dreamy" },
            new Category() {CategoryId = "002", Name = "Sky" },
            new Category() {CategoryId = "003", Name = "Sky Pillowtop" },
            new Category() {CategoryId = "004", Name = "Aqua Memory" },
            new Category() {CategoryId = "005", Name = "Calma" }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product() {ProductId = "01010010001", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "90x200", CategoryId = "001" },
            new Product() {ProductId = "01010010002", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "100x200", CategoryId = "001" },
            new Product() {ProductId = "01010010003", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "110x200", CategoryId = "001" },
            new Product() {ProductId = "01010010004", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "120x200", CategoryId = "001" },
            new Product() {ProductId = "01010010005", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "140x200", CategoryId = "001" },
            new Product() {ProductId = "01010010006", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "150x200", CategoryId = "001" },
            new Product() {ProductId = "01010010007", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "160x200", CategoryId = "001" },
            new Product() {ProductId = "01010010008", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "180x200", CategoryId = "001" },
            new Product() {ProductId = "01010010009", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Dimension = "200x200", CategoryId = "001" },
            new Product() {ProductId = "01010020001", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "90x200", CategoryId = "002" },
            new Product() {ProductId = "01010020002", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "100x200", CategoryId = "002" },
            new Product() {ProductId = "01010020003", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "110x200", CategoryId = "002" },
            new Product() {ProductId = "01010020004", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "120x200", CategoryId = "002" },
            new Product() {ProductId = "01010020005", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "140x200", CategoryId = "002" },
            new Product() {ProductId = "01010020006", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "150x200", CategoryId = "002" },
            new Product() {ProductId = "01010020007", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "160x200", CategoryId = "002" },
            new Product() {ProductId = "01010020008", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "180x200", CategoryId = "002" },
            new Product() {ProductId = "01010020009", Name = "Sky", Description = "Sky Connected Pocket 26CM", Dimension = "200x200", CategoryId = "002" }

            );
    }
}