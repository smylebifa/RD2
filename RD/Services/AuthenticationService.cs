﻿using RD.Data;
using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RD.Services;

namespace RD.Services
{
    public class AuthenticationService
    {
        //private readonly TestDbContext _dbContext;

        //public AuthenticationService(TestDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        private static readonly List<Person> Persons = new List<Person>
        {
                new Person(1, "admin", Hash("123" + "1234567890"), "1234567890"),
                new Person(2, "ivan", Hash("123" + "1234567891"), "1234567891"),
        };

        // Если имя пользователя найдено в базе, возвращаем его Id, иначе создаем нового пользователя
        public void Register(string login, string password, string email)
        {

            //var person = _dbContext.Persons.FirstOrDefault(x => x.Login == login);
            //if (person != null)
            //    return person.Id;

            //var salt = RandomString(10);

            ////Guid Id = Guid.NewGuid();

            //var newPerson = new Person() { Id = 2, Login = login, PasswordHash = Hash(password + salt), Salt = salt };

            //_dbContext.Persons.Add(newPerson);

            //_dbContext.Users.Add(new User(2, login, password, ""));

            //_dbContext.SaveChanges();

            //return newPerson.Id;


            var salt = RandomString(10);

            //Guid Id = Guid.NewGuid();

            int LastId = Persons.Max(user => user.Id);

            var newPerson = new Person() { Id = LastId, Login = login, PasswordHash = Hash(password + salt), Salt = salt };

            Persons.Add(newPerson);

            UsersService.Users.Add(new User(LastId, login, password, email));

        }

        public bool IsUserExist(string login)
        {

            var person = Persons.FirstOrDefault(x => x.Login == login);

            if (person != null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Проверяем существует ли пользователь в базе данных с таким именем, если существует проверяем совпадает ли пароль
        public bool Login(string login, string password)
        {
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Login == login);
            //if (person == null)
            //    return false;

            //return person.PasswordHash == Hash(password + person.Salt);


            var person = Persons.FirstOrDefault(x => x.Login == login);
            if (person == null)
                return false;

            return person.PasswordHash == Hash(password + person.Salt);
        }

        // Вычисляем хеш по паролю с помощью криптографического алгоритма SHA256 
        private static string Hash(string password)
        {
            var algorithm = HashAlgorithm.Create("SHA256");
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(algorithm!.ComputeHash(passwordBytes));
        }

        // Генерируем рандомную строку заданной длины
        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
