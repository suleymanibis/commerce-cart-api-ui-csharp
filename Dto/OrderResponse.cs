using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Dto
{
    public record OrderResponse(long orderId, string deliveryAddress, string status, decimal totalAmount, DateTime orderDate, List<OrderItemResponse> items);
}
