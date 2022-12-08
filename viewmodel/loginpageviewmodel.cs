

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mathematical_Qizz.model;
using Mathematical_Qizz.pages;
using Mathematical_Qizz.services;
using System.Collections.ObjectModel;

namespace Mathematical_Qizz.viewmodel
{
    public partial class loginpageviewmodel: ObservableObject
    {
        private Iloginrepository _loginrepository;
        public loginpageviewmodel(Iloginrepository login)
        {
            _loginrepository = login;
        }
        public ObservableCollection<Login> userinfolist { get; set; } = new ObservableCollection<Login>();
        public ObservableCollection<Login> userinfolistt { get; set; } = new ObservableCollection<Login>();
        public ObservableCollection<Login> userinfolisttt { get; set; } = new ObservableCollection<Login>();
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private int score;



        [RelayCommand]
        public async void Login()
        {

            var loginlist = await _loginrepository.LoginAsync();
            var result = new Login();
            Boolean hasvalue = false;
            foreach (var login in loginlist)
            {
                userinfolist.Add(login);
            }
            for (int i = 0; i < userinfolist.Count; i++)
            {
                if (checkforuserifo(userinfolist[i]))
                {
                    hasvalue = true;
                    result = userinfolist[i];
                }
            }
            if (hasvalue == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Exercise)}");

            }

            else
            {
                await Shell.Current.DisplayAlert("login failed", "invalid credentials", "ok");
            }
        }


        [RelayCommand]
        public async void Register()
        {
            var lg = new Login();
            bool ischeck = false;
            if (username != null && password != null)
            {
                var loginlistw = await _loginrepository.LoginAsync();
                foreach (var i in loginlistw)
                {
                    if (checkforuserifo(i))
                    {
                        lg.password = i.password;
                        lg.username = i.username;
                        lg.score = score;
                        ischeck = true;
                        break;
                    }
                }
                if (ischeck)
                {
                    await _loginrepository.UpdateUserAsync(lg);
                }
                else
                {

                    await _loginrepository.AdduserAsync(new Login
                    {
                        username = username,
                        password = password,
                    });

                    await Shell.Current.GoToAsync("//Loginpage");
                }

            }
        }

        [RelayCommand]
        async void Button_Clicked()
        {
            await Shell.Current.GoToAsync(nameof(register));
        }
        [RelayCommand]
        async void Getuserinfo()
        {
            var loginlistt = await _loginrepository.LoginAsync();
            if (loginlistt?.Count > 0)
            {
                userinfolistt.Clear();
                foreach (var login in loginlistt)
                {
                    userinfolistt.Add(login);
                }
            }
        }

        public bool checkforuserifo(Login lg)
        {
            if (lg.username == username && lg.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}