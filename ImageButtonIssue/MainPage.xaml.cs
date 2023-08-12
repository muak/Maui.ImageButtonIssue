namespace ImageButtonIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        Dispatcher.DispatchDelayed(TimeSpan.FromSeconds(3), () =>
        {
            overlay.IsVisible = false;
            // workaround
            //this.ForceLayout();
        });
    }
}


