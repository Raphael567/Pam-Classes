using CommunityToolkit.Mvvm.ComponentModel;
using JokenPo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JokenPo.ViewModels
{
    public partial class JokenPo_ViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;
        private ICommand JogarCommand { get; set; }

        Player jogador = new Player("Lites");
        Oponnent oponente = new Oponnent("Máquina");

        string pl_escolha = jogador.Pl_escolha;
    }
}
