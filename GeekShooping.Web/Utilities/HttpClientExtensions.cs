using System.Text.Json;

namespace GeekShooping.Web.Utilities
{
    public static class HttpClientExtensions
    {
        public static async Task<T> ReadContentTAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) 
                throw new ApplicationException(
                    $"something went wrong when calling the API: " + 
                    $"{response.ReasonPhrase}");
            //convertendo o JSON para objeto:
            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(dataAsString, new JsonSerializerOptions 
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
