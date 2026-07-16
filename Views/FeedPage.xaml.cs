namespace FIsioNet.Views;


public partial class FeedPage : ContentPage
{
	public FeedPage()
	{
		InitializeComponent();
	}

	public async void BtnPostPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PostPage));
    }

    public async void BtnProfilePage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ProfilePage));
    }
}