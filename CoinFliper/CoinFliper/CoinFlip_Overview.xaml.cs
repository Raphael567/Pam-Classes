namespace CoinFliper;

public partial class CoinFlip_Overview : ContentPage
{
	public CoinFlip_Overview()
	{
		InitializeComponent();
	}

    private void FlipButton_Clicked(object sender, EventArgs e)
    {
		String selectedSide = sidePicker.SelectedItem as String;
		String sortedSide = new Random().Next(2).ToString();
		if (sortedSide == "0")
			showResult.Text = $"Você escolheu {selectedSide} e caiu Cara";
		else
			showResult.Text = $"Você escolheu {selectedSide} e caiu Coroa";
    }
}