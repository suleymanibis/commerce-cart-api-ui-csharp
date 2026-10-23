using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text.Json;
using E_Commerce_Cart_API_UI.Dto;
using E_Commerce_Cart_API_UI.Managers;

namespace E_Commerce_Cart_API_UI.Client
{
    public class AppClient
    {
        private readonly HttpClient _httpClient;
        private readonly FileManager _sessionManager;
        
        public AppClient(HttpClient httpClient, FileManager sessionManager)
        {
            _sessionManager = sessionManager;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("http://localhost:8080");
        }

        private void SetAuthHeader()
        {
            JsonElement jsonNode = _sessionManager.ReadSession<JsonElement>();

            if (jsonNode.ValueKind != JsonValueKind.Undefined &&
               jsonNode.ValueKind != JsonValueKind.Null &&
               jsonNode.TryGetProperty("token", out JsonElement tokenElement))
            {
                string? token = tokenElement.GetString();

                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
            }
        } 

        public async Task<Result<TResponse>> SendRequestAsync<TRequest, TResponse>(HttpMethod method, string endpoint, TRequest requestBody)
        {
            try
            {
                SetAuthHeader();

                var request = new HttpRequestMessage(method, endpoint);

                if(requestBody != null) // we send null when we get
                {
                    request.Content = JsonContent.Create(requestBody);
                }

                var response = await _httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    TResponse? responseData = await response.Content.ReadFromJsonAsync<TResponse>();
                    return new Result<TResponse>(true, responseData, null);
                }
                else
                {
                    try
                    {
                        ApiErrorResponse? errorData = await response.Content.ReadFromJsonAsync<ApiErrorResponse>();
                        string? errorMessage = errorData?.message ?? "Occurrs an unknown API error.";
                        return new Result<TResponse>(false, default, errorMessage);
                    }
                    catch(JsonException)
                    {
                        string plainError = await response.Content.ReadAsStringAsync();
                        return new Result<TResponse>(false, default, string.IsNullOrWhiteSpace(plainError) ? $"Error code: {response.StatusCode}" : plainError);
                    }
                }
            }
            catch(Exception ex)
            {
                return new Result<TResponse>(false, default, $"Occurrs an error: {ex}");
            }
            
        }
    }
}
