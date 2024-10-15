namespace MauiDemo.Pages;

[QueryProperty(nameof(FromExo7), "FromExo7")]
public partial class Exo9 : ContentPage
{
    private string _fromExo7;

    public string FromExo7
    {
        get => _fromExo7;
        set
        {
            _fromExo7 = value;
            OnPropertyChanged(nameof(FromExo7)); // Notifie la vue du changement de valeur
        }
    }

    public Exo9()
	{
		InitializeComponent();
		FromExo7 = "Pas encore set";
        BindingContext = this;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("/Exo7?FromExo9=helloFromExo9jhfkjfh");
    }
}