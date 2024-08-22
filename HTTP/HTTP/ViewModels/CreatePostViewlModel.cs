using CommunityToolkit.Mvvm.ComponentModel;
using HTTP.Models;
using HTTP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HTTP.ViewModels
{
    public partial class CreatePostViewlModel : ObservableObject
    {
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
        [ObservableProperty]
        int id;
        [ObservableProperty]
        int userId;
        
        public ICommand SavePostCommand { get; }

        public CreatePostViewlModel()
        {
            SavePostCommand = new Command(SavePost);
        }

        public async void SavePost()
        {
            Posts post = new Posts();
            Posts newPost = new Posts();
            post.Title = Title;
            post.Body = Body;
            post.UserId = userId;

            PostService postService = new PostService();
            newPost = await postService.SavePostAsync(post);
        }
    }
}
