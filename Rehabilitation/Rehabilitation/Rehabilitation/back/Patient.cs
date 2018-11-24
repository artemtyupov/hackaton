using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Rehabilitation
{
    public struct PatientIdAndFullName
    {
        public int id;
        public string fullName;
    }

    class Patient : User
    {


        //Конструктор уже созданного доктора(предположительно не созданого доктора 
        // быть не может тк при реги делается юзер а из него потом доктор)
        public Patient(string login, string password, TypeUser type) : base(login, password)
        {
            int sqlId = 2;
            this.id = sqlId;
            this.type = type;
        }

        ////////////////////////////////////////////////////////////////////////////////// 
        //////////////////////////////////MenuBar Course//////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        //Событие нажатия на менюбар для получения курса(если он есть)
        void CoursesInfo()
        {

        }

        //Кнопка нажатия в списке на курс
        void CourseInfo()
        {

        }

        ////////////////////////////////////////////////////////////////////////////////// 
        //////////////////////////////////MenuBar Exercise////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        //Кнопка начало выполнения упражнения\завершения упражнения
        void ProcessExercise()
        {

        }


    }
}
