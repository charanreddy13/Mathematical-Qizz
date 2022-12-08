using Mathematical_Qizz.viewmodel;

namespace Mathematical_Qizz.pages;

public partial class scoreboard : ContentPage
{
    public readonly loginpageviewmodel loginpageview;
    public scoreboard(loginpageviewmodel vm)
    {
        InitializeComponent();
        loginpageview = vm;
        BindingContext = vm;
        OnAppearing();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        loginpageview.GetuserinfoCommand.Execute(null);
    }
}