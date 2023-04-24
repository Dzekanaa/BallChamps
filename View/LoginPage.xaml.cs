namespace BallChamps.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	async void LoginButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new HomePage());
	}
	async void OnSignUpClicked(object sender, TappedEventArgs args)
	{
	    	await Navigation.PushModalAsync(new SignUpPage());
	}
	async void OnForgotPasswordClicked(object sender, TappedEventArgs args)
	{
	    	await Navigation.PushModalAsync(new ForgotPasswordPage());
	}
}
