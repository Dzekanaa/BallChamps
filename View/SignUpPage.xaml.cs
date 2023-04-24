namespace BallChamps.View;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
	async void SignInButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new HomePage());
	}
	async void OnSignUpClicked(object sender, TappedEventArgs args)
	{
	    	await Navigation.PushModalAsync(new LoginPage());
	}
}
