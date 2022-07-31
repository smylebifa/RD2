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
    public class UsersService : IUsersService
    {
        private readonly TestDbContext _dbContext;

        public UsersService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToArray();
        }

        public void AddUser(User user)
        {
            if (_dbContext.Users.Any(x => x.Login == user.Login))
                throw new ArgumentException("User with such name already exists.");

            _dbContext.Users.Add(user);

            var salt = RandomString(10);
            var newPerson = new Person()
            {
                Id = user.Id,
                Login = user.Login,
                PasswordHash = Hash(user.Password + salt),
                Salt = salt,
            };

            _dbContext.Persons.Add(newPerson);

            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            if (existing == null)
                return;

            existing.Login = user.Login;
            existing.Password = user.Password;
            existing.IsActive= true;

            _dbContext.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            if (existing == null)
                return;

            _dbContext.Users.Remove(existing);
            _dbContext.Persons.Remove(person);

            _dbContext.SaveChanges();
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
            var existing = _dbContext.Users.FirstOrDefault(x => x.Login == newLogin);
            var user = _dbContext.Users.FirstOrDefault(x => x.Login == oldLogin);
            var person = _dbContext.Persons.FirstOrDefault(x => x.Login == oldLogin);

            if (existing != null)
                return false;

            user.Login = newLogin;
            person.Login = newLogin;

            _dbContext.SaveChanges();

            return true;

        }

        public void ChangePassword(string login, string oldPassword, string newPassword, string newPassword2)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Login == login);
            var person = _dbContext.Persons.FirstOrDefault(x => x.Login == login);
                        
            if (newPassword == newPassword2 && user.Password == oldPassword) {
                var salt = RandomString(10);
                user.Password = newPassword;
                person.Salt = salt;
                person.PasswordHash = Hash(newPassword + salt);
            }
            
            //_dbContext.Persons.Add(newPerson);

            _dbContext.SaveChanges();
        }

    }
}
