﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace text_mining
{
    class Person
    {
        private string name;
        private string surname;
        private string secname;
        private int age;
        private string birthday;
        private string phone;
        private string gender;
        private string status;
        private string addres;

        public Person()
        {
            name = "Нет данных";
            surname = "Нет данных";
            secname = "Нет данных";
            age = 0;
            birthday = "Нет данных";
            phone = "Нет данных";
            gender = "Нет данных";
            status = "Нет данных";
            addres = "Нет данных";

        }
        /// <summary>
        /// Заполнение персональных данных
        /// </summary>
        /// <param name="name">Имя</param>
        public Person(string name)
        {
            this.name = name;
            surname = "Нет данных";
            secname = "Нет данных";
            birthday = "Нет данных";
            phone = "Нет данных";
            gender = "Нет данных";
            status = "Нет данных";
            addres = "Нет данных";
        }

        /// <summary>
        /// Заполнение персональных данных
        /// </summary>
        /// <param name="name">Имя, если неизвестно, то в качестве параметра указывать null</param>
        /// <param name="surname">Фамилия, если неизвестно, то в качестве параметра указывать null</param>
        /// <param name="secname">Отчество, если неизвестно, то в качестве параметра указывать null</param>
        /// <param name="birthday">Дата рождения, то если неизвестно, в качестве параметра указывать null</param>
        /// <param name="phone">Номер телефона, то если неизвестно, в качестве параметра указывать null</param>
        /// <param name="gender">Пол, если неизвестно, в качестве параметра указывать null</param>
        /// <param name="status">Должность, если неизвестно, в качестве параметра указывать null</param>
        /// <param name="addres">Адрес, если неизвестно, в качестве параметра указывать null</param>
        public Person(string name, string surname, string secname, string birthday, string phone, string gender, string status,string addres)
        {
            if (name==null)
            {
                this.name = "Нет данных";
            }
            else
            {
                this.name = name;
            }
            if (surname == null)
            {
                this.surname = "Нет данных";
            }
            else
            {
                this.surname = surname;
            }

            if (secname == null)
            {
                this.secname = "Нет данных";
            }
            else
            {
                this.secname = secname;
            }

            if (birthday == null)
            {
                this.birthday = "Нет данных";
            }
            else
            {
                this.birthday = birthday;
            }
            if (phone == null)
            {
                this.phone = "Нет данных";
            }
            else
            {
                this.phone = phone;
            }
            if (gender == null)
            {
                this.gender = "Нет данных";
            }
            else
            {
                this.gender = gender;
            }
            if (status==null)
            {
                this.status = "Нет данных"; 
            }
            else
            {
                this.status = status;
            }
            if (addres == null)
            {
                this.addres = "Нет данных";
            }
            else
            {
                this.addres = addres;
            }
        }
    }
}
