using HTTP.Models;
using HTTP.ViewModels;

namespace HTTP.Views;

public partial class PostView : ContentPage
{
    public PostView()
    {
        InitializeComponent();
        BindingContext = new PostViewModel();
    }
}