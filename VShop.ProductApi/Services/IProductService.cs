﻿using VShop.ProductApi.DTOs;

namespace VShop.ProductApi.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int id);
        Task AddProduct(ProductDTO productDTO);
        Task UpdateProduct(ProductDTO product);
        Task RemoveProduction(int id);
    }
}
