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
            ResultLabel.Text = $"Sonuç: {result}";
        }
        else
        {
            ResultLabel.Text = "Geçersiz giriþ!";
        }
    }

    private void OnSubtractClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Number1Entry.Text, out double num1) && double.TryParse(Number2Entry.Text, out double num2))
        {
            double result = num1 - num2;
            ResultLabel.Text = $"Sonuç: {result}";
        }
        else
        {
            ResultLabel.Text = "Geçersiz giriþ!";
        }
    }

    private void OnMultiplyClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Number1Entry.Text, out double num1) && double.TryParse(Number2Entry.Text, out double num2))
        {
            double result = num1 * num2;
            ResultLabel.Text = $"Sonuç: {result}";
        }
        else
        {
            ResultLabel.Text = "Geçersiz giriþ!";
        }
    }

    private void OnDivideClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Number1Entry.Text, out double num1) && double.TryParse(Number2Entry.Text, out double num2))
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                ResultLabel.Text = $"Sonuç: {result}";
            }
            else
            {
                ResultLabel.Text = "Hata: Sýfýra bölünemez!";
            }
        }
        else
        {
            ResultLabel.Text = "Geçersiz giriþ!";
        }
    }
}
