using Mathematical_Qizz.viewmodel;

namespace Mathematical_Qizz.pages;

public partial class register : ContentPage
{
	public register(loginpageviewmodel hs)
	{
		InitializeComponent();
        BindingContext = hs;

    }
}