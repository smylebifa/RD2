using RD.Data;
using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RD.Services
{
    public class UsersService
    //public class UsersService : IUsersService
    {
        //private readonly TestDbContext _dbContext;

        //public UsersService(TestDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public static List<User> Users = new List<User>
        {
                new User(1, "admin", "123", "", "" , true),
                new User(2, "ivan", "123", "", "", true),
        };

        public IEnumerable<User> GetUsers()
        {
            return Users;
            //return _dbContext.Users.ToArray();
        }

        public bool AddUser(User user)
        {
            if (Users.Any(x => x.Login == user.Login))
                return false;
            
            int LastId = Users.Max(user => user.Id);
            if (LastId is int)
            {
                user.Id = LastId + 1;
                user.IsAdmin = false;
                user.IsActive = true;

                Users.Add(user);
            }

            return true;

            //if (_dbContext.Users.Any(x => x.Login == user.Login))
            //    throw new ArgumentException("User with such name already exists.");

            //_dbContext.Users.Add(user);

            //var salt = RandomString(10);
            //var newPerson = new Person()
            //{
            //    Id = user.Id,
            //    Login = user.Login,
            //    PasswordHash = Hash(user.Password + salt),
            //    Salt = salt,
            //};

            //_dbContext.Persons.Add(newPerson);

            //_dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            //if (existing == null)
            //    return;

            //existing.Login = user.Login;
            //existing.Password = user.Password;
            //existing.IsActive= true;

            //_dbContext.SaveChanges();

            var existing = Users.FirstOrDefault(x => x.Id == user.Id);
            if (existing == null)
                return;
            existing.Login = user.Login;
            existing.Password = user.Password;
            existing.FullName = user.FullName;
            existing.IsActive = user.IsActive;
            existing.IsAdmin = user.IsAdmin;
        }

        public void DeleteUser(int id)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            //if (existing == null)
            //    return;

            //_dbContext.Users.Remove(existing);
            //_dbContext.Persons.Remove(person);

            //_dbContext.SaveChanges();

            var existing = Users.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Users.Remove(existing);
        }

        private string Hash(string password)
        {
            var algorithm = HashAlgorithm.Create("SHA256");
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(algorithm!.ComputeHash(passwordBytes));
        }

        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public bool ChangeLogin(string oldLogin, string newLogin)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Login == newLogin);
            //var user = _dbContext.Users.FirstOrDefault(x => x.Login == oldLogin);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Login == oldLogin);

            //if (existing != null)
            //    return false;

            //user.Login = newLogin;
            //person.Login = newLogin;

            //_dbContext.SaveChanges();

            var existing = Users.FirstOrDefault(x => x.Login == oldLogin);
            if (existing != null)

                existing.Login = newLogin;

            return true;

        }

        public void ChangePassword(string login, string oldPassword, string newPassword, string newPassword2)
        {
            //var user = _dbContext.Users.FirstOrDefault(x => x.Login == login);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Login == login);

            //if (newPassword == newPassword2 && user.Password == oldPassword)
            //{
            //    var salt = RandomString(10);
            //    user.Password = newPassword;
            //    person.Salt = salt;
            //    person.PasswordHash = Hash(newPassword + salt);
            //}

            ////_dbContext.Persons.Add(newPerson);

            //_dbContext.SaveChanges();


            var existing = Users.FirstOrDefault(x => x.Password == oldPassword);
            if (existing != null)
            {
                if (newPassword == newPassword2)
                {
                    existing.Password = newPassword;
                }
                    
            }

                
        }

    }
}
