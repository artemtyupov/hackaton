using System;
using System.Collections.Generic;
using System.Text;

namespace Rehabilitation
{
    
    class Doctor : User
    {


        //Конструктор уже созданного доктора(предположительно не созданого доктора 
        // быть не может тк при реги делается юзер а из него потом доктор)
        public Doctor(string login, string password, TypeUser type) : base(login, password)
        {
            int sqlId = 2;
            this.id = sqlId;
            this.type = type;
        }

        ////////////////////////////////////////////////////////////////////////////////// 
        //////////////////////////////////MenuBar Patients////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        //Событие нажатия на менюбар для получения пациентов(если они есть)
        void PatientsInfo()
        {

        }


        //Метод получения массива структур типа Имя пациента, ИД пациента, для
        // реализации списка пациентов вошедшего в систему врача
        PatientIdAndFullName[] GetPatients()
        {
            int sqlCount = 5;//sql Селект на количество пациентов у врача
            PatientIdAndFullName[] arr = new PatientIdAndFullName[sqlCount];
            int sqlId = 2;
            string sqlFullName = "Test";
            for (int i = 0; i < sqlCount; i++)
            {
                arr[i].id = sqlId;
                arr[i].fullName = sqlFullName;   
            }
            return arr;
        }

        //Прикрепления пациента к врачу
        void AddPatient(int id)
        {
            //sql Делаем инсерт в пациента по переданному id(вставляем id самого врача)
            //sql if id != (select id from patients) then throw ex
        }

        //Кнопка нажатия в списке на пациента
        void PatientInfo()
        {

        }

        ////////////////////////////////////////////////////////////////////////////////// 
        //////////////////////////////////MenuBar Courses/////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        //Событие нажатия на менюбар для получения курса(если он есть)
        void CoursesInfo()
        {

        }

        //Добавления курса к врачу в список
        void AddCourse(string name, int angle, int numDays, int numExercises)
        {
            Course newCourse = new Course(name, angle, numDays, numExercises);
            //sql Курс создан, отправить в бд все данные о нем, прикрепить за ним idDoctor!!
        }

        //Кнопка нажатия в списке на курс
        void CourseInfo()
        {

        }


    }
}
