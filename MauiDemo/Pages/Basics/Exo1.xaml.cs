namespace MauiDemo.Pages;

public partial class Exo1 : ContentPage
{
	public Exo1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		MyLabel.Text = UserInput.Text;
    }
}