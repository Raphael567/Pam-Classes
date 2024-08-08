using HTTP.Models;
using System;
using System.Collections.Generic;
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
        private List<Posts> posts;

        public PostService()
        {
            _httpClient = new HttpClient();
            JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }
    }

    public async Task<List<Posts>> GetPostsAsync()
    {
        Items = new List<> 
    }
}
