using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace numi.src.domain.Models;
public class Category
{
    public string CategoryId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public virtual ObservableCollectionListSource<Product> Products {get;} = [];
}