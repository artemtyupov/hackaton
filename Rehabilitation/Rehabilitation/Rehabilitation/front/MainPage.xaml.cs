using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Rehabilitation
{
    public partial class MainPage : ContentPage
    {
        SensorSpeed speed = SensorSpeed.UI;

        public MainPage()
        {
            InitializeComponent();
            Gyroscope.ReadingChanged += Gyroscope_ReadingChanged;

        }

        void Gyroscope_ReadingChanged(object sender, GyroscopeChangedEventArgs e)
        {
            var data = e.Reading;
            // Process Angular Velocity X, Y, and Z
            //Вывод координат каких то
            enLog.Text = ($"Reading: X: {data.AngularVelocity.X}, Y: {data.AngularVelocity.Y}, Z: {data.AngularVelocity.Z}");
        }

        private async void btSingIn_Clicked(object sender, EventArgs e)
        {
            TypeUser res = SignIn(enLog.Text, enPass.Text);
            if (res == TypeUser.Doctor)
                await Navigation.PushAsync(new enterPage());
            else
                await Navigation.PushAsync(new enterPage());
        }

        private async void btSingUp_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new registrationPage());

            try
            {

                if (Gyroscope.IsMonitoring)
                    Gyroscope.Stop();
                else
                    Gyroscope.Start(speed);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }

        }

        //Метод для входа в приложения
        static TypeUser SignIn(string login, string password)
        {
            TypeUser res; 
            string sqlLogin = "testLog";//sql
            string sqlPassword = "testPass";
            if (sqlLogin != login || sqlPassword != password)
                throw new ArgumentException();
            string sqlType = "doctor";
            if (sqlType == TypeUser.Doctor.ToString())
            {
                res = TypeUser.Doctor;
            }
            else
            {
                res = TypeUser.Patient;
            }
            return res;

        }

        
    }
}
