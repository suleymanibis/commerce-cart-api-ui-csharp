using System;
using System.Collections.Generic;
using System.Text;
using Singulink.Numerics;

namespace E_Commerce_Cart_API_UI.Dto
{
    public record CreateProductRequest(string name, string description, decimal price, int stockQuantity);
}
