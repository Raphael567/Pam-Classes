using CoinFlipper.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoinFliper.ViewModel
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagem;

        [ObservableProperty]
        private string escolha;

        public ICommand JogarCommand { get; }

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            //Instanciando uma moeda
            //Sorteio um lado
            //Comparo ao lado sorteado com a escolha do jogador
            //Exibo o  resultado

            Coin coin = new Coin();
            coin.Jogar();

            if (Escolha == coin.LadoSorteado)
            {
                Resultado = $"Você escolheu {Escolha} e caiu Coroa";
                Imagem = "moeda_coroa.png";
            }
            else
            {
                Resultado = $"Você escolheu {Escolha} e caiu Cara";
                Imagem = "moeda_cara.png";
            }
        }
    }
}
