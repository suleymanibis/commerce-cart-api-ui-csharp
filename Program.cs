using E_Commerce_Cart_API_UI.Client;
using E_Commerce_Cart_API_UI.Enums;
using E_Commerce_Cart_API_UI.Forms;
using E_Commerce_Cart_API_UI.Managers;
using E_Commerce_Cart_API_UI.Services;
using E_Commerce_Cart_API_UI.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace E_Commerce_Cart_API_UI
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var builder = Host.CreateDefaultBuilder();

            builder.ConfigureServices((context, services) =>
            {
                services.AddHttpClient<AppClient>();
                services.AddSingleton<AuthService>();
                services.AddSingleton<ProductService>();
                services.AddSingleton<CartService>();
                services.AddSingleton<OrderService>();
                services.AddSingleton<FileManager>();
                services.AddSingleton<FileUtils>();
                services.AddSingleton<JwtUtils>();
                services.AddTransient<MainForm>(); // Enum: MAIN_PAGE Class: MainForm()
                services.AddTransient<StartingForm>(); // Enum: START_PAGE Class: StartingForm()
                services.AddTransient<CartForm>();
                services.AddTransient<OrderHistoryForm>();
            });

            var host = builder.Build();

            var sessionManager = host.Services.GetRequiredService<FileManager>();
            var jwtUtils = host.Services.GetRequiredService<JwtUtils>();

            Form startingForm;
            string? token = "";
            PageType pageType = PageType.START_PAGE;
            

            JsonElement jsonNode = sessionManager.ReadSession<JsonElement>();

            if(jsonNode.ValueKind != JsonValueKind.Undefined && 
               jsonNode.ValueKind != JsonValueKind.Null && 
               jsonNode.TryGetProperty("token", out JsonElement tokenElement))
            {
                token = tokenElement.GetString();

                if (!string.IsNullOrWhiteSpace(token))
                {
                    if (jwtUtils.IsTokenValid(token))
                    {
                        pageType = PageType.MAIN_MENU;
                        
                    }
                }

                
            }

            switch (pageType)
            {
                case PageType.START_PAGE:
                    startingForm = host.Services.GetRequiredService<StartingForm>();
                    break;
                case PageType.MAIN_MENU:
                    startingForm = host.Services.GetRequiredService<MainForm>();
                    break;
                default:
                    startingForm = host.Services.GetRequiredService<StartingForm>();
                    break;
            }

            Application.Run(startingForm);
        }
    }
}