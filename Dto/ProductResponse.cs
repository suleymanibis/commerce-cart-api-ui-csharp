using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Dto
{
    public record ProductResponse(long id, string name, string description, decimal price, int stockQuantity, string status);
}
