using BallChamps.View;

namespace BallChamps;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	async void LoginButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
		await Navigation.PushAsync(new LoginPage());
	}
	async void SignUpButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
		await Navigation.PushAsync(new SignUpPage());
	}
}

