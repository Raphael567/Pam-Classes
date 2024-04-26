namespace CoinFliper;

public partial class CoinFlip_TwoPlayers : ContentPage
{
	public CoinFlip_TwoPlayers()
	{
		InitializeComponent();
	}

    private void FlipButton_Clicked_1(object sender, EventArgs e)
    {
        String selectedSideOne = P1sidePicker.SelectedItem as String;
        String selectedSideTwo = P2sidePicker.SelectedItem as String;

        String sortedSide = new Random().Next(2).ToString();

        switch (sortedSide)
        {
            case "0":

                if (selectedSideOne == "Cara")
                    showResult.Text = "Cara, Player 1 ganhou";
                else if (selectedSideTwo == "Cara")
                    showResult.Text = "Cara, Player 2 ganhou";
                else if (selectedSideOne == "Cara" && selectedSideTwo == selectedSideOne)
                    showResult.Text = "Coroa, ambos escolheram iguais";
                break;

            case "1":

                if (selectedSideOne == "Coroa")
                    showResult.Text = $"Coroa, Player 1 ganhou";
                else if (selectedSideTwo == "Coroa")
                    showResult.Text = $"Coroa, Player 2 ganhou";
                else if (selectedSideOne == "Cara" && selectedSideTwo == selectedSideOne)
                    showResult.Text = "Cara, ambos escolheram iguais";
                break;
        }
    }
}