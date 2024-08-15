using CommunityToolkit.Mvvm.ComponentModel;
using HTTP.Models;
using HTTP.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HTTP.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Posts> posts;
        PostService postsService;
        public ICommand getPostsCommand { get; }

        public PostViewModel()
        {
            getPostsCommand = new Command(getPosts);
            postsService = new PostService();
        }

        public async void getPosts()
        {
            Posts = await postsService.GetPostsAsync();
        }
    }
}
