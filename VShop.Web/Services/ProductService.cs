using System.Text.Json;
using VShop.Web.Models;
using VShop.Web.Services.Contracts;

namespace VShop.Web.Services;

public class ProductService : IProductService
{
    private readonly IHttpClientFactory _clienteFactory;
    private const string apiEndpoint = "/api/products";
    private readonly JsonSerializerOptions _options;
    private ProductViewModel productVM;
    private IEnumerable<ProductViewModel> productsVM;

    public ProductService(IHttpClientFactory clienteFactory)
    {
        _clienteFactory = clienteFactory;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public Task<IEnumerable<ProductViewModel>> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel> FindProductVyId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel> CreateProduct(ProductViewModel productVM)
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel> UpdateProduct(ProductViewModel productVM)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProductById(int id)
    {
        throw new NotImplementedException();
    }
}
