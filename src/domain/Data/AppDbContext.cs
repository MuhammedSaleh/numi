using Microsoft.EntityFrameworkCore;
using numi.src.domain.Models;

namespace numi.src.domain.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;

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
            new Category() {CategoryId = "005", Name = "Calma" },
            new Category() {CategoryId = "006", Name = "Pillow Hollow" }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product() {ProductId = "01010010001", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 90, Length= 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010010002", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 100, Length = 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010010003", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 110, Length = 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010010004", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 120, Length = 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010010005", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 140, Length = 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010010006", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 150, Length = 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010010007", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 160, Length = 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010010008", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 180, Length = 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010010009", Name = "Dreamy", Description = "Dreamy Connected Pocket Height 23CM", Width = 200, Length = 200, Height = 32, CategoryId = "001" },
            new Product() {ProductId = "01010020001", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 90, Length = 200, Height = 26, CategoryId = "002" },
            new Product() {ProductId = "01010020002", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 100, Length = 200, Height = 26, CategoryId = "002" },
            new Product() {ProductId = "01010020003", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 110, Length = 200, Height = 26, CategoryId = "002" },
            new Product() {ProductId = "01010020004", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 120, Length = 200, Height = 26, CategoryId = "002" },
            new Product() {ProductId = "01010020005", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 140, Length = 200, Height = 26, CategoryId = "002" },
            new Product() {ProductId = "01010020006", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 150, Length = 200, Height = 26, CategoryId = "002" },
            new Product() {ProductId = "01010020007", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 160, Length = 200, Height = 26, CategoryId = "002" },
            new Product() {ProductId = "01010020008", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 180, Length = 200, Height = 26, CategoryId = "002" },
            new Product() {ProductId = "01010020009", Name = "Sky", Description = "Sky Connected Pocket Height 26CM", Width = 200, Length = 200, Height = 26, CategoryId = "002" },

            new Product() {ProductId = "01010030001", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 90, Length = 200, Height = 31, CategoryId = "003" },
            new Product() {ProductId = "01010030002", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 100, Length = 200, Height = 31, CategoryId = "003" },
            new Product() {ProductId = "01010030003", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 110, Length = 200, Height = 31, CategoryId = "003" },
            new Product() {ProductId = "01010030004", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 120, Length = 200, Height = 31, CategoryId = "003" },
            new Product() {ProductId = "01010030005", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 140, Length = 200, Height = 31, CategoryId = "003" },
            new Product() {ProductId = "01010030006", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 150, Length = 200, Height = 31, CategoryId = "003" },
            new Product() {ProductId = "01010030007", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 160, Length = 200, Height = 31, CategoryId = "003" },
            new Product() {ProductId = "01010030008", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 180, Length = 200, Height = 31, CategoryId = "003" },
            new Product() {ProductId = "01010030009", Name = "Sky Pillowtop", Description = "Sky Pillowtop Connected Pocket Height 31CM", Width = 200, Length = 200, Height = 31, CategoryId = "003" },

            new Product() {ProductId = "01011010001", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 90, Length = 200, Height = 28, CategoryId = "004" },
            new Product() {ProductId = "01011010002", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 100, Length = 200, Height = 28, CategoryId = "004" },
            new Product() {ProductId = "01011010003", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 110, Length = 200, Height = 28, CategoryId = "004" },
            new Product() {ProductId = "01011010004", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 120, Length = 200, Height = 28, CategoryId = "004" },
            new Product() {ProductId = "01011010005", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 140, Length = 200, Height = 28, CategoryId = "004" },
            new Product() {ProductId = "01011010006", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 150, Length = 200, Height = 28, CategoryId = "004" },
            new Product() {ProductId = "01011010007", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 160, Length = 200, Height = 28, CategoryId = "004" },
            new Product() {ProductId = "01011010008", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 180, Length = 200, Height = 28, CategoryId = "004" },
            new Product() {ProductId = "01011010009", Name = "Aqua Memory", Description = "Aqua Memory Disconnected Pocket Height 28CM American", Width = 200, Length = 200, Height = 28, CategoryId = "004" },

            new Product() { ProductId = "01011020001", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 90, Length = 200, Height = 27, CategoryId = "005" },
            new Product() { ProductId = "01011020002", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 100, Length = 200, Height = 27, CategoryId = "005" },
            new Product() { ProductId = "01011020003", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 110, Length = 200, Height = 27, CategoryId = "005" },
            new Product() { ProductId = "01011020004", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 120, Length = 200, Height = 27, CategoryId = "005" },
            new Product() { ProductId = "01011020005", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 140, Length = 200, Height = 27, CategoryId = "005" },
            new Product() { ProductId = "01011020006", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 150, Length = 200, Height = 27, CategoryId = "005" },
            new Product() { ProductId = "01011020007", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 160, Length = 200, Height = 27, CategoryId = "005" },
            new Product() { ProductId = "01011020008", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 180, Length = 200, Height = 27, CategoryId = "005" },
            new Product() { ProductId = "01011020009", Name = "Calma", Description = "Calma Disconnected Pocket Height 27CM", Width = 200, Length = 200, Height = 27, CategoryId = "005" },

            new Product() { ProductId = "00000000001", Name = "Fiber Hollow", Description = "Pillow Fiber Hollow 50x70", Width = 70, Length = 50, CategoryId = "006" }


            );
    }
}