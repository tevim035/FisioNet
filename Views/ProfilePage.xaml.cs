namespace FIsioNet.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

	public async void BtnVoltar_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(FeedPage));
    }
}