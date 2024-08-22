using HTTP.ViewModels;

namespace HTTP.Views;

public partial class CreatePost : ContentPage
{
    public CreatePost()
    {
        InitializeComponent();
        BindingContext = new CreatePostViewlModel();
    }
}