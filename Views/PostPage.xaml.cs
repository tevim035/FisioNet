namespace FIsioNet.Views;

public partial class PostPage : ContentPage
{
	public PostPage()
	{
		InitializeComponent();
	}
    public async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(FeedPage));
    }
}