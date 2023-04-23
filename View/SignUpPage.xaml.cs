namespace BallChamps.View;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
	async void SignInButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
		await Navigation.PushAsync(new HomePage());
	}
}