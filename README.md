# Commerce Cart API UI

`Commerce Cart API UI` is a Windows desktop client for managing e-commerce shopping cart operations through a REST API. The application provides user registration and login, product catalog management, shopping cart operations, order creation, and order history through a Windows Forms interface.

> This repository contains the desktop client only. The API used by the client must be running separately.

## Technology stack

- C# and .NET 10
- Windows Forms (`net10.0-windows`)
- `Microsoft.Extensions.Hosting` and dependency injection
- `HttpClient` via `Microsoft.Extensions.Http`
- `System.Text.Json`
- FluentValidation
- JWT token validation with `System.IdentityModel.Tokens.Jwt` and `Microsoft.IdentityModel.Tokens`
- Visual Studio solution: `E-Commerce-Cart-API-UI.slnx`

## Requirements

- Windows
- .NET 10 SDK
- A reachable Commerce Cart API
- The API listening at `http://localhost:8080`

## Setup

1. Clone the repository and change to its directory:

   ```powershell
   git clone https://github.com/suleymanibis/commerce-cart-api-ui-csharp.git
   cd commerce-cart-api-ui-csharp
   ```

2. Restore the NuGet dependencies:

   ```powershell
   dotnet restore
   ```

3. Confirm that the API is running and reachable at `http://localhost:8080`.

## API connection configuration

The API base address is defined in the `AppClient` constructor in `Client/AppClient.cs`:

```csharp
_httpClient.BaseAddress = new Uri("http://localhost:8080");
```

To use a different API address, update this value for the target environment and rebuild the project. After login, the application stores the JWT response in `sessions.json` and automatically sends the token as an `Authorization: Bearer <token>` header on subsequent requests. User details are stored in `user_config.json`; logging out removes both files.

## Running the application

From the command line:

```powershell
dotnet run --project .\E-Commerce-Cart-API-UI.csproj
```

With Visual Studio, open `E-Commerce-Cart-API-UI.slnx`, select `E-Commerce-Cart-API-UI` as the startup project, and run with `F5` or `Ctrl+F5`.

If a valid saved session is found, the application opens the main menu. Otherwise, it opens the login and registration screen.

## User flow

1. Register a new account or sign in from the starting screen.
2. Browse the product catalog. Users with the `ADMIN` role can add and delete products.
3. Select a product and quantity, then add it to the cart.
4. From the cart screen, remove products, increase quantities, or clear the cart.
5. Enter a delivery address and create an order.
6. Open the order history to review the user's orders.
7. Log out to remove the local JWT session and user configuration.

The client uses the following API endpoints:

| Operation | HTTP | Endpoint |
| --- | --- | --- |
| Register | `POST` | `/api/auth/register` |
| Login | `POST` | `/api/auth/login` |
| Current user | `GET` | `/api/auth/me` |
| List products | `GET` | `/api/products` |
| Create product | `POST` | `/api/products` |
| Delete product | `DELETE` | `/api/products/{productId}` |
| Get current cart | `GET` | `/api/cart` |
| Add cart item | `POST` | `/api/cart/items` |
| Remove cart item | `DELETE` | `/api/cart/items/{productId}` |
| Clear cart | `DELETE` | `/api/cart` |
| Create order | `POST` | `/api/orders` |
| List orders | `GET` | `/api/orders` |

## Build and validation

```powershell
dotnet restore
dotnet build .\E-Commerce-Cart-API-UI.csproj
dotnet run --project .\E-Commerce-Cart-API-UI.csproj
```

The repository does not contain a separate test project or test files, so no automated unit-test suite is defined. Validate changes by building the project and manually exercising the user, product, cart, and order flows with the API running.

## Project structure

```text
Client/      HTTP client and shared API request handling
Dto/         Request and response models
Enums/       Page and user-role constants
Forms/       Windows Forms screens
Managers/    Session and user configuration file management
Services/    Authentication, product, cart, and order services
Utils/       File and JWT helpers
Validators/  Request validators
Program.cs   Application startup and dependency-injection registration
```
