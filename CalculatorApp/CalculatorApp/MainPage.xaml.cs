using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBackspaceButtonClicked(object sender, EventArgs e)
        {
           
        }

        private void OnDigitButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
            backspaceButton.IsEnabled = true;
        }
        private void OnDivButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
        }
        private void OnMultiplyButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
        }
        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
        }
        private void OnMinusButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
        }
        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            DisplayLabel.Text = "";
        }
        //private void OnDigitButtonClicked(object sender, EventArgs e)

    }
}
