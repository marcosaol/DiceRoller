using DiceRoller.Models;
using DiceRoller.ViewModels;

namespace DiceRoller.Views
{
    public partial class DiceView : ContentPage
    {
        public DiceView()
        {
            InitializeComponent();
            BindingContext = new DiceViewModel();
        }

    }
    }
