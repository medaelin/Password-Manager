namespace Password_Manager.Views;

public partial class NewUserView : ContentPage
{
	public NewUserView()
	{
		InitializeComponent();
	}
    private async void OnSubmit(object sender, EventArgs e)
    {
        // Continued in part 2
        await Navigation.PushAsync(new PasswordListView());
    }
}