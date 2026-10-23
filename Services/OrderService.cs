using E_Commerce_Cart_API_UI.Client;
using E_Commerce_Cart_API_UI.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Services
{
    public class OrderService
    {
        private readonly AppClient _client;

        public OrderService(AppClient appClient)
        {
            _client = appClient;
        }

        public async Task<Result<OrderResponse>> CreateOrder(CreateOrderRequest request)
        {
            Result<OrderResponse> result = await _client.SendRequestAsync<CreateOrderRequest, OrderResponse>(
                method: HttpMethod.Post,
                endpoint: "/api/orders",
                requestBody: request
                );

            return result;
        }

        public async Task<Result<List<OrderResponse>>> GetOrders()
        {
            Result<List<OrderResponse>> result = await _client.SendRequestAsync<object, List<OrderResponse>>(
                method: HttpMethod.Get,
                endpoint: "/api/orders",
                requestBody: null
                );

            return result;
        }
    }
}
