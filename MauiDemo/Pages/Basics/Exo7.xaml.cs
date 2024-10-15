namespace MauiDemo.Pages;

[QueryProperty(nameof(FromExo9), "FromExo9")]
public partial class Exo7 : ContentPage
{
    private string _fromExo9;
    public string FromExo9
    {
        get => _fromExo9;
        set
        {
            _fromExo9 = value;
            OnPropertyChanged(nameof(FromExo9)); // Notifie la vue du changement de valeur
        }
    }
    public Exo7()
	{
		InitializeComponent();
		FromExo9 = "Pas encore set";
		BindingContext = this;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		var navigationParameter = new Dictionary<string, object>
		{
			{"FromExo7", "Hello from exo 7" }
		};

        //Shell.Current.GoToAsync("/Exo9", navigationParameter);
        await Shell.Current.GoToAsync("///Exo9", navigationParameter);
    }
}