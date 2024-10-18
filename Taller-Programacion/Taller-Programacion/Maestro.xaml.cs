namespace Taller_Programacion;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void goToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented = true;  // Cierra el menú Flyout después de la navegación
    }

    private void OnNavigateToFetchPage(object sender, EventArgs e)
    {
        goToPage(new Pages.FetchPage());
    }

    private void OnNavigateToPushPage(object sender, EventArgs e)
    {
        goToPage(new Pages.PushPage());
    }

    private void OnNavigateToPullPage(object sender, EventArgs e)
    {
        goToPage(new Pages.PullPage());
    }

    private void OnNavigateToCommitPage(object sender, EventArgs e)
    {
        goToPage(new Pages.CommitPage());

    }
}