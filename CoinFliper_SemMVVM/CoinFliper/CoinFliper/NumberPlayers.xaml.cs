namespace CoinFliper;

public partial class NumberPlayers : ContentPage
{
	public NumberPlayers()
	{
		InitializeComponent();
    }

    private async void OnePlayerButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CoinFlip_Overview());
    }

    private async void TwoPlayersButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CoinFlip_TwoPlayers());
    }
}