using System;
using System.Collections.Generic;
using System.Text;

namespace Rehabilitation
{
    //Последовательность типа юзера(доктор\пациент)
    enum TypeUser
    {
        Doctor,
        Patient
    }

    //Последовательность пола(муж\жен)
    enum SexEnum
    {
        Male,
        Female
    };

    //Класс всех пользователей приложения
    class User
    {
        public int id;
        public TypeUser type;

        private string login;
        private string password;
        private string fullName;
        private string telephoneNumber;
        private SexEnum sex;
        private string email;
        private int age;

        //Конструктор при регистрации(данные из формы)
        public User(string login, string password, string fullName)
        {
            this.id = GetId();//Если есть общая таблица юезров то последний ид из них, если нет, то хз
            this.fullName = fullName;
            this.login = login;
            this.password = password;
        }

        //Конструктор созданного юзера(данные из бд)
        public User(string login, string password)
        {
            int sqlId = 2;
            this.id = sqlId;
            GetInfo();
        }

        //Метод генерации id(1 2 3 4 5 6 7)
        static int GetId()
        {
            int id;
            Random rand = new Random();
            int sqlLastId = 0; //sql Последний id юзера
            if (sqlLastId == 0)
                id = 1;
            else
                id = sqlLastId + 1;
            sqlLastId++;
            return id;
        }

        ////////////////////////////////////////////////////////////////////////////////// 
        //////////////////////////////////MenuBar Profile/////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        //Событие нажатия на менюбар для получения профиля
        void ProfileInfo()
        {

        }


        //Кнопка нажатия галочка после редактирования\добавления данных
        void SetInfo(string fullName, string telephoneNumber, string email, int age, SexEnum sex)
        {
            string sqlfullName = "Test", sqlTelephoneNumber = "89688968400",
                sqlEmail = "artem3090@mail.ru";
            int sqlAge = 18;
            SexEnum sqlSex = SexEnum.Male;
            if (sqlfullName != fullName)
            {
                this.fullName = fullName;
                //sql Делаем инсерт в бд для изменения данных в бд
            }

            if (sqlTelephoneNumber != telephoneNumber)
            {
                this.telephoneNumber = fullName;
                //Делаем инсерт в бд для изменения данных в бд
            }

            if (sqlEmail != email)
            {
                this.email = email;
                //Делаем инсерт в бд для изменения данных в бд
            }

            if (sqlAge != age)
            {
                this.age = age;
                //Делаем инсерт в бд для изменения данных в бд
            }

            if (sqlSex != sex)
            {
                this.sex = sex;
                //Делаем инсерт в бд для изменения данных в бд
            }
        }

        //Метод полученеия и записи всей информации из бд в наш объект юзера\доктора\пациента
        void GetInfo()
        {
            //sql Селектом по id выбираем все данные из бд
            string sqlLogin = "Test";
            string sqlPassword = "Test";
            string sqlfullName = "Test";
            int sqlAge = 18;
            SexEnum sqlSex = SexEnum.Male;
            string sqlEmail = "artem3090@mail.ru";
            string sqlTelephoneNumber = "89688968400";

            this.login = sqlLogin;
            this.password = sqlPassword;
            this.fullName = sqlfullName;
            this.age = sqlAge;
            this.sex = sqlSex;
            this.email = sqlEmail;
            this.telephoneNumber = sqlTelephoneNumber;
        }
    }
}
