using CoinFliper.ViewModel;

namespace CoinFliper.Views;

public partial class CoinView : ContentPage
{
    public CoinView()
    {
        InitializeComponent();
        BindingContext = new CoinViewModel();
    }
}