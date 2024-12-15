namespace numi.src.domain.Models;

public class Product
{
    public string ProductId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Width { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public string Dimension => Width.ToString() + "x" + Length.ToString() + "x" + Height;
    public string CategoryId { get; set; } = string.Empty;
    public virtual Category Category { get; set; } = null!;

    public override string ToString()
    {
        return $"{Name} {Description} {Width}";
    }

}