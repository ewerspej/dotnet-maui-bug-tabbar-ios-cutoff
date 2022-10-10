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

        //setting this to true, then false and true again will lead to the cut-off
        Shell.SetTabBarIsVisible(this, height > width);
    }
}
