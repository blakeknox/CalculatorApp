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
        List<string> Calculate = new List<string>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBackspaceButtonClicked(object sender, EventArgs e)
        {
           if(DisplayLabel.Text.Length >= 1)
            {
                string text = DisplayLabel.Text;
                DisplayLabel.Text = text.Substring(0, text.Length - 1);
                if(DisplayLabel.Text.Length >= 1 )
                {
                    Divbutton.IsEnabled = false;
                    Multiplybutton.IsEnabled = false;
                    Addbutton.IsEnabled = false;
                    Minusbutton.IsEnabled = false;
                    Equalbutton.IsEnabled = false;
                    
                }
            }
           
        }

        private void OnDigitButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
            backspaceButton.IsEnabled = true;
            Divbutton.IsEnabled = true;
            Multiplybutton.IsEnabled = true;
            Addbutton.IsEnabled = true;
            Minusbutton.IsEnabled = true;
            Equalbutton.IsEnabled = true;
        }
        private void OnDivButtonClicked(object sender, EventArgs e)
        {
            Calculate.Add(DisplayLabel.Text);
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
            Divbutton.IsEnabled = false;
            Multiplybutton.IsEnabled = false;
            Addbutton.IsEnabled = false;
            Minusbutton.IsEnabled = false;
            Equalbutton.IsEnabled = false;
        }
        private void OnMultiplyButtonClicked(object sender, EventArgs e)
        {
            Calculate.Add(DisplayLabel.Text);
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
            Divbutton.IsEnabled = false;
            Multiplybutton.IsEnabled = false;
            Addbutton.IsEnabled = false;
            Minusbutton.IsEnabled = false;
            Equalbutton.IsEnabled = false;
        }
        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Calculate.Add(DisplayLabel.Text);
            Button button = (Button)sender;
            DisplayLabel.Text = (string)button.StyleId;
            Divbutton.IsEnabled = false;
            Multiplybutton.IsEnabled = false;
            Addbutton.IsEnabled = false;
            Minusbutton.IsEnabled = false;
            Equalbutton.IsEnabled = false;
        }
        private void OnMinusButtonClicked(object sender, EventArgs e)
        {
            Calculate.Add(DisplayLabel.Text);
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
            Divbutton.IsEnabled = false;
            Multiplybutton.IsEnabled = false;
            Addbutton.IsEnabled = false;
            Minusbutton.IsEnabled = false;
            Equalbutton.IsEnabled = false;
        }
        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            DisplayLabel.Text = "";
            Divbutton.IsEnabled = true;
            Multiplybutton.IsEnabled = true;
            Addbutton.IsEnabled = true;
            Minusbutton.IsEnabled = true;
            Equalbutton.IsEnabled = true;
            Calculate.Clear();
        }
        private void OnEqualButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DisplayLabel.Text += (string)button.StyleId;
        }

    }
}
