using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Dto
{
    public record OrderItemResponse(long productId, string productName, int quantity, decimal unitPrice);
}
