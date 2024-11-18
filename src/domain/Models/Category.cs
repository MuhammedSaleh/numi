using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace numi.src.domain.Models;
public class Category
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public ObservableCollectionListSource<Product> Products {get;} = [];
}