namespace MixNativeBlazor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    void BtnRender_Clicked(System.Object sender, System.EventArgs e)
    {
        var paramPerfil = new Dictionary<string, object>()
        {
            { "Nombre", "Hector Tristan"}
        };
        Shell.Current.GoToAsync("//PerfilPage", paramPerfil);
    }
}

