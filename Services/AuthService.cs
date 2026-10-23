using E_Commerce_Cart_API_UI.Client;
using E_Commerce_Cart_API_UI.Dto;
using E_Commerce_Cart_API_UI.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Services
{
    public class AuthService
    {
        private readonly AppClient _client;
        private readonly FileManager _sessionManager;

        public AuthService(AppClient client, FileManager sessionManager)
        {
            _client = client;
            _sessionManager = sessionManager;
        }

        public async Task<Result<RegisterResponse>> RegisterAsync(RegisterRequest registerRequest)
        {
            Result<RegisterResponse> result = await _client.SendRequestAsync<RegisterRequest, RegisterResponse>(
                method: HttpMethod.Post, 
                endpoint: "/api/auth/register", 
                requestBody: registerRequest
                );

            return result;
        }

        public async Task<Result<LoginResponse>> LoginAsync(LoginRequest loginRequest)
        {
            Result<LoginResponse> result = await _client.SendRequestAsync<LoginRequest, LoginResponse>(
                method: HttpMethod.Post,
                endpoint: "/api/auth/login",
                requestBody: loginRequest
                );

            if(result.isSuccess)
            {
                if (result.Data != null)
                {
                    _sessionManager.SaveSession<LoginResponse>(result.Data);
                }
            }

            return result;
        }

        public async Task<Result<UserResponse>> GetMe()
        {
            Result<UserResponse> result = await _client.SendRequestAsync<object, UserResponse>(
                method: HttpMethod.Get,
                endpoint: "/api/auth/me",
                requestBody: null
                );

            if (result.isSuccess)
            {
                if (result.Data != null)
                {
                    _sessionManager.SaveConfig<UserResponse>(result.Data);
                }
            }

            return result;
        }
    }
}
