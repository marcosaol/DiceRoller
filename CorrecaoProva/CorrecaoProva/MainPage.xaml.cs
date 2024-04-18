namespace CorrecaoProva
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void RollButton_Clicked(object sender, EventArgs e)
        {
            //Pego o valor que o usuário selecionou no Picker
            //Sorteio de 1 até X
            //Soretio um número aleatório ENTRE 1 e X, onde X é o número de lados
            //Exibo o resultado da rolagem do dado na Label

            int selectedSides = Convert.ToInt32(SidesPicker.SelectedItem);
            int sortedNumber = new Random().Next(1, selectedSides + 1);
            ResultLabel.Text = sortedNumber.ToString();
        }
    }

}
