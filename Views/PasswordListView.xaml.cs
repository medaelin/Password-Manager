using System.Collections.ObjectModel;

namespace Password_Manager.Views
{
    public partial class PasswordListView : ContentPage
    {
        public ObservableCollection<PasswordItem> Passwords { get; set; }

        public PasswordListView()
        {
            InitializeComponent();

            // Create dummy data for passwords
            Passwords = new ObservableCollection<PasswordItem>
            {
                new PasswordItem { Platform = "Facebook", Password = "********" },
                new PasswordItem { Platform = "YouTube", Password = "********" },
                new PasswordItem { Platform = "Twitter", Password = "********" }
            };

            // Bind data to CollectionView
            BindingContext = this;
        }

        private async void OnAddPassword(object sender, EventArgs e)
        {
            // Navigate to the New Password View
            await Navigation.PushAsync(new NewPasswordView());
        }

        private void CopyPassToClipboard(object sender, EventArgs e)
        {

        }

        private void EditPassword(object sender, EventArgs e)
        {

        }

        private void DeletePassword(object sender, EventArgs e)
        {

        }
    }

    // Model for passwords
    public class PasswordItem
    {
        public string Platform { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
