using System;
using System.Collections.Generic;
using System.Text;

namespace Rehabilitation
{
    class Course
    {
        public int id;
        public string name;
        public int angle;
        public int numDays;
        public int numExercises;

        //Конструктор нового курса
        public Course(string name, int angle, int numDays, int numExercises)
        {
            this.id = GetId();
            this.name = name;
            this.angle = angle;
            this.numDays = numDays;
            this.numExercises = numExercises;
        }

        //Конструктор созданного курса
        public Course(string name)
        {
            this.name = name;
            GetInfo();
        }

        void GetInfo()
        {
            int sqlId = 2;
            int sqlAngle = 10;
            int sqlNumDays = 5;
            int sqlNumExercises = 15;
            this.id = sqlId;
            this.angle = sqlAngle;
            this.numDays = sqlNumDays;
            this.numExercises = sqlNumExercises;
        }

        //Метод генерации id(1 2 3 4 5 6 7)
        static int GetId()
        {
            int id;
            Random rand = new Random();
            int sqlLastId = 0; //sql Последний id Курса
            if (sqlLastId == 0)
                id = 1;
            else
                id = sqlLastId + 1;
            sqlLastId++;
            return id;
        }

    }
}
