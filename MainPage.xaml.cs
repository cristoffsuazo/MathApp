using System;
namespace MathApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SumButton_Clicked(object sender, EventArgs e)
        {
            double num1, num2;
            if (double.TryParse(num1Entry.Text, out num1) && double.TryParse(num2Entry.Text, out num2))
            {
                double result = num1 + num2;
                Navigation.PushAsync(new ResultPage($"Resultado: {result}"));
            }
            else
            {
                resultLabel.Text = "Error: ingrese números válidos";
            }
        }

        private void SubButton_Clicked(object sender, EventArgs e)
        {
            double num1, num2;
            if (double.TryParse(num1Entry.Text, out num1) && double.TryParse(num2Entry.Text, out num2))
            {
                double result = num1 - num2;
                Navigation.PushAsync(new ResultPage($"Resultado: {result}"));
            }
            else
            {
                resultLabel.Text = "Error: ingrese números válidos";
            }
        }

        private void MulButton_Clicked(object sender, EventArgs e)
        {
            double num1, num2;
            if (double.TryParse(num1Entry.Text, out num1) && double.TryParse(num2Entry.Text, out num2))
            {
                double result = num1 * num2;
                Navigation.PushAsync(new ResultPage($"Resultado: {result}"));
            }
            else
            {
                resultLabel.Text = "Error: ingrese números válidos";
            }
        }

        private void DivButton_Clicked(object sender, EventArgs e)
        {
            double num1, num2;
            if (double.TryParse(num1Entry.Text, out num1) && double.TryParse(num2Entry.Text, out num2))
            {
                double result = num1 / num2;
                Navigation.PushAsync(new ResultPage($"Resultado: {result}"));
            }
            else
            {
                resultLabel.Text = "Error: ingrese números válidos";
            }
        }
    }
}