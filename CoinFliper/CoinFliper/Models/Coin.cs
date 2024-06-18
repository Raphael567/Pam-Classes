using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipper.Models
{
    public class Coin
    {
        public string LadoEscolhido { get; set; }
        public string LadoSorteado { get; set; }

        //Método Construtor
        public Coin()
        {

        }

        //Método Jogar a moeda. Retorna o Lado sorteado como uma string
        public string Jogar()
        {
            LadoSorteado = new Random().Next(2) == 0 ? "Cara" : "Coroa";
            return (LadoSorteado);
        }
    }
}
