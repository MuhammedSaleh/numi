namespace numi.src.domain.Models;

    public class Product
{
    public string ProductId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Dimension { get; set; } = string.Empty;
    public string CategoryId { get; set; } = string.Empty;
    public virtual Category Category { get; set; } = null!;

}