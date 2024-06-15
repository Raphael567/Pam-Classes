using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo.Models
{
    public partial class Player : ObservableObject
    {
        [ObservableProperty]
        private string pl_escolha;
        private string nome { get; set; }

        public Player(string nome)
        {
            this.nome = nome;
        }

        public void Pl_escolha()
        {
            string escolha = pl_escolha;
        }
    }
}
