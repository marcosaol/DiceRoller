using Microsoft.UI.Xaml.Controls.Primitives;
using System.Collections.Generic;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiceRoller;

public partial class DiceRoller : ContentPage
{
    

	public DiceRoller()
	{

        InitializeComponent();

		var diceList = new List<string>();

		diceList.Add("4");
        diceList.Add("6");
        diceList.Add("10");
        diceList.Add("20");
        diceList.Add("100");

        Picker picker = new Picker { Title = "Quantidade de lados"};
        picker.ItemsSource = diceList;

    }

    private void ButtonDiceRoller_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();

        int selectedIndex = picker.SelectedIndex;

        var numero = Convert.ToInt32(showNumber.Text);
        var sortedNumber = random.Next(numero);
        if(sortedNumber > 0)
        {
            showNumber.Text = Convert.ToString(sortedNumber).ToString();
        }
        
    }

    private void picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        string selectedItem = (string)picker.SelectedItem;
        showNumber.Text = selectedItem;
    }
}