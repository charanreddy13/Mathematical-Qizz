using Mathematical_Qizz.viewmodel;

namespace Mathematical_Qizz.pages;

public partial class Loginpage : ContentPage
{
	public Loginpage(loginpageviewmodel his)
	{
		InitializeComponent();
        BindingContext = his;
    }
}