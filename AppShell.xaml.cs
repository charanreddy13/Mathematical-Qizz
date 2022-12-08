using Mathematical_Qizz.pages;

namespace Mathematical_Qizz;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(register), typeof(register));
        Routing.RegisterRoute(nameof(Loginpage), typeof(Loginpage));
        Routing.RegisterRoute(nameof(Exercise), typeof(Exercise));
        Routing.RegisterRoute(nameof(Loginpage), typeof(Loginpage));
    }
}
