using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Dto
{
    public record AddToCartRequest(long productId, int quantity);
}
