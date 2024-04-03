
namespace ProvaMAUI1
{
    public partial class MainPage : ContentPage
    {
        int quantidadeLados = 0;
        int numeroSorteado = 0;
        Random rnd = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDiceRollClicked(object sender, EventArgs e)
        {
            if (DiceSidesPck.SelectedIndex != -1) {
                quantidadeLados = (int)DiceSidesPck.ItemsSource[DiceSidesPck.SelectedIndex];
                numeroSorteado = rnd.Next(1, quantidadeLados+1);
                DiceNumberLbl.Text = $"{numeroSorteado}";

            }
        } 
    }
}