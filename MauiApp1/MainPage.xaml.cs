namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (username == "admin" && password == "1234")
        {
            // Giriş başarılı, Hesap Makinesi Sayfasına geç
            Navigation.PushAsync(new CalculatorPage());
        }
        else
        {
            // Hatalı giriş
            ErrorLabel.Text = "Kullanıcı adı veya şifre hatalı!";
            ErrorLabel.IsVisible = true;
        }
    }
}
