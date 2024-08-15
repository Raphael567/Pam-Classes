using HTTP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HTTP.Services
{
    public class PostService
    {

        private HttpClient _httpClient;
        private JsonSerializerOptions _serializerOptions;
        private ObservableCollection<Posts> posts;

        public PostService()
        {
            _httpClient = new HttpClient();
            JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        public async Task<ObservableCollection<Posts>> GetPostsAsync()
        {
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    posts = JsonSerializer.Deserialize<ObservableCollection<Posts>>(content, _serializerOptions);
                }
            }
            catch
            {

            }
            return posts;
        }
    }
}
