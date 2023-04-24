namespace BallChamps.View;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}
	async void OnEditProfileButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new EditProfilePage());
	}
}
