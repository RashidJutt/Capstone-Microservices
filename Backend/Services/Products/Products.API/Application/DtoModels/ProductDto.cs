namespace Products.API.Application.DtoModels;

public class ProductDto
{
    public int ProductId { get; set; }
    public string ProductNumber { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
}
