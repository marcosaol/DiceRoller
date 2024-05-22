using CommunityToolkit.Mvvm.ComponentModel;
using DiceRoller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace DiceRoller.ViewModels
{
    public partial class DiceViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _resultado;
        [ObservableProperty]
        private int _numeroSelecionado;

        public ICommand RollCommand { get; }

        public void Roll()
        {
            Dice dice = new Dice(NumeroSelecionado);
            dice.Rolar();
            Resultado = dice.sortedNumber;
        }

        public DiceViewModel() { 
            RollCommand = new Command(Roll);
        }
    }
}
