namespace Taller_Programación;

public partial class Maestro : ContentPage
{
	public Maestro()
	{
		InitializeComponent();
	}

    private void goToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented = true;  // Cierra el menú Flyout después de la navegación
    }

    // Método que se ejecutará cuando el botón sea presionado
    private void OnNavigateToFetchPage(object sender, EventArgs e)
    {
        // Navegar a FetchPage usando el método goToPage
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