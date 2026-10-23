using E_Commerce_Cart_API_UI.Client;
using E_Commerce_Cart_API_UI.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace E_Commerce_Cart_API_UI.Services
{
    public class CartService
    {
        private readonly AppClient _client;

        public CartService(AppClient appClient)
        {
            _client = appClient;
        }

        public async Task<Result<CartResponse>> AddToCart(AddToCartRequest request)
        {
            Result<CartResponse> result = await _client.SendRequestAsync<AddToCartRequest, CartResponse>(
                method: HttpMethod.Post,
                endpoint: "/api/cart/items",
                requestBody: request
                );

            return result;
        }

        public async Task<Result<CartResponse>> GetCurrentCart()
        {
            Result<CartResponse> result = await _client.SendRequestAsync<object, CartResponse>(
                method: HttpMethod.Get,
                endpoint: "/api/cart",
                requestBody: null
                );

            return result;
        }

        public async Task<Result<CartResponse>> RemoveProduct(long productId)
        {
            Result<CartResponse> result = await _client.SendRequestAsync<object, CartResponse>(
                method: HttpMethod.Delete,
                endpoint: $"/api/cart/items/{productId}",
                requestBody: null
                );

            return result;
        }

        public async Task<Result<CartResponse>> ClearCart()
        {
            Result<CartResponse> result = await _client.SendRequestAsync<object, CartResponse>(
                method: HttpMethod.Delete,
                endpoint: $"/api/cart",
                requestBody: null
                );

            return result;
        }
    }
}
