using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Dto
{
    public record class Result<T>(bool isSuccess, T? Data, string? errorMessage);
}
