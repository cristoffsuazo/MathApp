using System;

namespace MathApp
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage(string result)
        {
            InitializeComponent();
            resultLabel.Text = $"Resultado: {result}";
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}