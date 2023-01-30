namespace WilianPepinos_P3;

public partial class App : Application
{
	public App()
	{
        InitializeComponent();
        Routing.RegisterRoute(nameof(Views.Page_Wp), typeof(Views.Page_Wp));
    }
}
