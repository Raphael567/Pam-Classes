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

        if (selectedSideOne != null && selectedSideTwo != null)
        {
            switch (sortedSide)
            {
                case "0":

                    if (selectedSideOne == "Cara" && selectedSideTwo == selectedSideOne)
                    {
                        showResult.Text = "Ambos escolheram iguais";
                        moedaImg.Source = "moeda_cara.png";
                    }
                    else if (selectedSideOne == "Cara")
                    {
                        showResult.Text = "Cara, Player 1 ganhou";
                        moedaImg.Source = "moeda_cara.png";
                    }
                    else if (selectedSideTwo == "Cara")
                    {
                        showResult.Text = "Cara, Player 2 ganhou";
                        moedaImg.Source = "moeda_cara.png";
                    }
                    break;

                case "1":

                    if (selectedSideOne == "Coroa" && selectedSideTwo == selectedSideOne)
                    {
                        showResult.Text = "Ambos escolheram iguais";
                        moedaImg.Source = "moeda_coroa.png";
                    }
                    else if (selectedSideOne == "Coroa")
                    {
                        showResult.Text = $"Coroa, Player 1 ganhou";
                        moedaImg.Source = "moeda_coroa.png";
                    }
                    else if (selectedSideTwo == "Coroa")
                    {
                        showResult.Text = $"Coroa, Player 2 ganhou";
                        moedaImg.Source = "moeda_coroa.png";
                    }
                    break;
            }
        } 
        else
        {
            showResult.Text = "Os jogadores precisam fazer uma escolha";
        }
    }
}