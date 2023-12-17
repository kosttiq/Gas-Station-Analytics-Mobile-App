using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    //public partial class LoginPage : ContentPage
    //{
    //public LoginPage()
    //{
    //    InitializeComponent();
    //  this.BindingContext = new LoginViewModel();
    //}
    //}
    //}

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsername.Text == "11" && txtPassword.Text == "11")
            {
                Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
            }
            else
            {
                DisplayAlert("Кажется, что-то пошло не так...", "Вы ввели неверный логин или пароль", "Ок");
            }
        }

    }
}
