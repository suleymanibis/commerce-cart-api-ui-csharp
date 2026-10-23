using E_Commerce_Cart_API_UI.Client;
using E_Commerce_Cart_API_UI.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace E_Commerce_Cart_API_UI.Services
{
    public class ProductService
    {
        private readonly AppClient _client;

        public ProductService(AppClient client)
        {
            _client = client;
        }

        public async Task<Result<ProductResponse>> CreateProduct(CreateProductRequest request)
        {
            Result<ProductResponse> result = await _client.SendRequestAsync<CreateProductRequest, ProductResponse>(
                method: HttpMethod.Post,
                endpoint: "/api/products",
                requestBody: request
                );

            return result;
        }

        public async Task<Result<BindingList<ProductResponse>>> GetProducts()
        {
            Result<BindingList<ProductResponse>> result = await _client.SendRequestAsync<object, BindingList<ProductResponse>>(
                method: HttpMethod.Get,
                endpoint: "/api/products",
                requestBody: null
                );

            return result;
        }

        public async Task<Result<ProductResponse>> DeleteProduct(long productId)
        {
            Result<ProductResponse> result = await _client.SendRequestAsync<object, ProductResponse>(
                method: HttpMethod.Delete,
                endpoint: $"/api/products/{productId}",
                requestBody: null
                );

            return result;
        }
    }
}
