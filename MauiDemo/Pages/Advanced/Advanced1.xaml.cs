namespace MauiDemo.Pages.Advanced;

public partial class Advanced1 : ContentPage
{
	public Advanced1()
	{
		InitializeComponent();
		ChangeColor();
	}

	public void ChangeColor()
	{
		if (DeviceInfo.Current.Platform == DevicePlatform.Android)
		{
            dynamicColor.Color = Colors.Blue;
		}
		else
		{
            dynamicColor.Color = Colors.Red;
		}
	}
}