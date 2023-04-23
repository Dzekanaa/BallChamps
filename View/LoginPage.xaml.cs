namespace BallChamps.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	async void LoginButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
		await Navigation.PushAsync(new HomePage());
	}
}
