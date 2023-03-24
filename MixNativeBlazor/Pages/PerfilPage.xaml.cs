namespace MixNativeBlazor.Pages;

[QueryProperty(nameof(Nombre),nameof(Nombre))]
public partial class PerfilPage : ContentPage
{
    string nombre;

    public string Nombre
    {
        get => nombre;
        set
        {
            nombre = value;
            rootComponent.Parameters =
            new Dictionary<string, object>
            {
                { "Nombre", value }
            };
            OnPropertyChanged();
        }
    }

	public PerfilPage()
	{
		InitializeComponent();
        BindingContext = this;
    }
}
