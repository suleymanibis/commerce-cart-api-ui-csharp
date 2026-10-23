using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace E_Commerce_Cart_API_UI.Dto
{
    public record CartResponse(long cartId, List<CartItemResponse> cartItems, decimal cartTotalPrice);
}
