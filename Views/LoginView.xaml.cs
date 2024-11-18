namespace Password_Manager.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void OnSubmit(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PasswordListView());
    }
}