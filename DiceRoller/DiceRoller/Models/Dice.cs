using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    internal class Dice
    {
        public int numero { get; set; }
        public int sortedNumber { get; set; }

        public Dice(int qtdLados)
        {
            numero = qtdLados;
        }
        public void Rolar() {
            sortedNumber = new Random().Next(numero) +1;
        }
    }
}
