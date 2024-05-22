
using System.Collections.Generic;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiceRoller;

public partial class DiceRoller : ContentPage
{
    

	public DiceRoller()
	{

        InitializeComponent();

    }

    private void ButtonDiceRoller_Clicked(object sender, EventArgs e)
    {
        if(picker.SelectedIndex == -1) {
            picker.SelectedIndex = 0;
        }

        Random random = new Random();


        var numero = Convert.ToInt32((string)picker.SelectedItem);
        var sortedNumber = random.Next(1, numero);
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