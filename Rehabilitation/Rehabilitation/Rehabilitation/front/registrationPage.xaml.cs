using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rehabilitation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registrationPage : ContentPage
    {
        public registrationPage()
        {
            InitializeComponent();
        }

        private async void btnReg_Clicked(object sender, EventArgs e)
        {
            //Registration(enLogin, enPass, enReentryPass, enFIO)
            await Navigation.PopAsync();
        }

        //Метод для регистрации в приложении
        static User Registration(string login, string password, string confirmationPassword,
            string fullName, string type)
        {
            //Не совпадение паролей
            if (password != confirmationPassword)
                throw new ArgumentException();

            string sqlLogin = "test";//sql

            //Логин уже существует
            if (sqlLogin == login)
                throw new ArgumentException();

            User user = new User(login, password, fullName);

            if (type == TypeUser.Doctor.ToString())
            {
                Doctor doc = new Doctor(login, password, TypeUser.Doctor);
            }
            else
            {
                Patient patient = new Patient(login, password, TypeUser.Patient);
            }


            //sql Если все ифы прошли заносим данные в бд, предположительно занос данных
            //идет по созданию конструктора


            //возврат по кнопке обратно в signIn

            return user;
        }

    }
}