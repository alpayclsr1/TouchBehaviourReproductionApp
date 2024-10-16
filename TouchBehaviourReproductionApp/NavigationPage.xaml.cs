namespace TouchBehaviourReproductionApp;

public partial class NavigationPage : ContentPage
{
	public NavigationPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.Navigation.PopModalAsync(false);
    }
}