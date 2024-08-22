using HTTP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HTTP.Services
{
    public class PostService
    {
        private readonly JsonSerializerOptions? jsonSerializerOptions;
        private HttpClient _httpClient;
        private Posts post;
        private JsonSerializerOptions _serializerOptions;
        private ObservableCollection<Posts> posts;

        Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");

        public PostService()
        {
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        public async Task<ObservableCollection<Posts>> GetPostsAsync()
        {
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

        public async Task<Posts> SavePostAsync(Posts item)
        {
            try
            {
                string json = JsonSerializer.Serialize<Posts>(item, jsonSerializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(uri, content);
                if (response.IsSuccessStatusCode) 
                {
                    Debug.WriteLine(response.Content);
                }
            }
            catch(Exception e){
                Debug.WriteLine(e.Message);
            }
            return post;
        }
    }
}
