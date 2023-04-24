namespace BallChamps.View;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
	}
	async void OnLoginClicked(object sender, TappedEventArgs args)
	{
	    	await Navigation.PushModalAsync(new LoginPage());
	}
}
