namespace MauiApp1;

public partial class CalculatorPage : ContentPage
{
    public CalculatorPage()
    {
        InitializeComponent();
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Number1Entry.Text, out double num1) && double.TryParse(Number2Entry.Text, out double num2))
        {
            double result = num1 + num2;
            ResultLabel.Text = $"Sonu�: {result}";
        }
        else
        {
            ResultLabel.Text = "Ge�ersiz giri�!";
        }
    }

    private void OnSubtractClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Number1Entry.Text, out double num1) && double.TryParse(Number2Entry.Text, out double num2))
        {
            double result = num1 - num2;
            ResultLabel.Text = $"Sonu�: {result}";
        }
        else
        {
            ResultLabel.Text = "Ge�ersiz giri�!";
        }
    }

    private void OnMultiplyClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Number1Entry.Text, out double num1) && double.TryParse(Number2Entry.Text, out double num2))
        {
            double result = num1 * num2;
            ResultLabel.Text = $"Sonu�: {result}";
        }
        else
        {
            ResultLabel.Text = "Ge�ersiz giri�!";
        }
    }

    private void OnDivideClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Number1Entry.Text, out double num1) && double.TryParse(Number2Entry.Text, out double num2))
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                ResultLabel.Text = $"Sonu�: {result}";
            }
            else
            {
                ResultLabel.Text = "Hata: S�f�ra b�l�nemez!";
            }
        }
        else
        {
            ResultLabel.Text = "Ge�ersiz giri�!";
        }
    }
}
