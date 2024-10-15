using MauiDemo.Views;

namespace MauiDemo.Pages;

public partial class Exo10 : ContentPage
{
	public Exo10()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var viewToLoad = new ContentViewBasic1();
		var viewToLoad2 = new ContentViewBasic2();

		CV1.Children.Clear();
		CV2.Children.Clear();

		CV1.Children.Add(viewToLoad);
		CV2.Children.Add(viewToLoad2);
    }
}