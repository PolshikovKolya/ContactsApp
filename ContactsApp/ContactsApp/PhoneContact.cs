using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, описывающий контакты.
    /// </summary>
    public class PhoneContact
    {
         /// <summary>
         /// поле класса Фамилия
         /// </summary>
        private string _surname;

        /// <summary>
        /// поле класса Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// поле класса Дата рождения
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// поле класса ID VK
        /// </summary>
        private string _idVK;

        /// <summary>
        /// поле класса Почта
        /// </summary>
        private string _email;

        /// <summary>
        /// Ограничение фамилии контакта в 50 символов
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Фамилия не должна быть больше 50 символов");
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Ограничение имени в 50 символов
        /// </summary>>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя должно содержать меньше 50 символов");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Метод, устанавливающий и возвращающий дату рождения контакта.
        /// </summary>
        public DateTime DateOfBirth
        {
            get { 
                return _dateOfBirth; 
            }
            set
            {
                DateTime curDate = DateTime.Now;
                if (value.Year < 1900 || value > curDate || value == null)
                {
                    throw new ArgumentException("Вы ввели некорректную дату рождения ");
                }
                else
                {
                    _dateOfBirth = value;
                }
            }
        }

        /// <summary>
        /// Ограничение ID VК  15 символов
        /// </summary>
        public string idVK
        {
            get 
            { 
                return _idVK; 
            }
            set
            {
                if (value.Length > 15 && value != null)
                {
                    throw new ArgumentException("ID  должен быть меньше 15 символов");
                }
                else
                {
                    _idVK = value;
                }
            }
        }

        /// <summary>
        /// Почта ограничена 50-ю символами
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Почта не может быть больше 50 символов");
                }

                _email = value;
            }
        }

        /// <summary>
        /// поле класса Номер телефона
        /// </summary>
        public PhoneNumber phoneNumber = new PhoneNumber();

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PhoneContact()
        {
        }

        /// <summary>
        /// Конструктор класса с 6 входными параметрами.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона контакта.</param> 
        /// <param name="name">Имя контакта.</param> .
        /// <param name="surname">Фамилия контакта.</param> 
        /// <param name="email">E-mail контакта.</param> 
        /// <param name="dateOfBirth">Дата рождения контакта.</param> 
        /// <param name="idVk">ID Vk контакта.</param> 
        public PhoneContact(long phoneNumber, string name, string surname, string email, DateTime dateOfBirth,
            string idVk)
        {
            this.phoneNumber.Number = phoneNumber;
            Name = name;
            Surname = surname;
            Email = email;
            DateOfBirth = dateOfBirth;
            idVK = idVk;
        }

        /// <summary>
        /// Реализация клонирования
        /// </summary>
        /// <returns>Возвращает объект - клон контакта, с полями: номер телефона, имя, фамилия, емейл, дата рождения, айди вк.</returns>
        public object Clone()
        {
            return new PhoneContact (phoneNumber.Number, Name, Surname, Email, DateOfBirth, idVK);
        }
    }
}
