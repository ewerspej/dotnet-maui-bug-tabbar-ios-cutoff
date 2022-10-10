namespace MauiTabBarCutoff;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        Shell.SetTabBarIsVisible(this, height > width);
    }
}
