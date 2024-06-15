using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo.Models
{
    public class Oponnent
    {
        private string op_escolha { get; set; }
        private string nome { get; set; }

        public Oponnent(string nome) 
        {
            this.nome = nome;
        }

        public void Op_Jogada()
        {
            Random random = new Random();

            int resultado = random.Next(0,3);

            switch (resultado)
            {
                case 0:
                    op_escolha = "Pedra";
                    break;

                case 1:
                    op_escolha = "Papel";
                    break;

                case 2:
                    op_escolha = "Tesoura";
                    break;
            }
        }
    }
}
