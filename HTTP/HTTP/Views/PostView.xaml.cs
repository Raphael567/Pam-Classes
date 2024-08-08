using HTTP.Models;

namespace HTTP.Views;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();

		var post = new Posts
		{
			PostId = 1,
			UserId = 1,
			PostTitle = "Receive",
			PostBody = "Receba"
		};
		BindingContext = post;
	}
}