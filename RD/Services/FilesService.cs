using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public class FilesService
    {

        public static List<File> Files = new List<File>
        {
                new File(1, "file1", "docx"),
                new File(2, "file2", "txt"),
        };

        public IEnumerable<File> GetFiles()
        {
            return Files;
            //return _dbContext.Users.ToArray();
        }

        public void AddFile(string fileName)
        {
            string[] subs = fileName.Split('.');

            if (subs.Count() > 0)
            {
                if (Files.Any(x => x.Filename == subs[0]))
                    throw new ArgumentException("User with such login already exists.");

                File file = new File();

                if (subs.Count() > 1)
                {
                    int LastId = Files.Max(user => user.Id);
                    if (LastId is int)
                    {
                        file.Id = LastId + 1;
                        file.Filename = subs[0];
                        file.EntityType = subs[1];

                        Files.Add(file);
                    }
                }
                else
                {
                    int LastId = Files.Max(user => user.Id);
                    if (LastId is int)
                    {
                        file.Id = LastId + 1;
                        file.Filename = subs[0];
                       
                        Files.Add(file);
                    }
                }

            }

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

        public void UpdateFile(File file)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            //if (existing == null)
            //    return;

            //existing.Login = user.Login;
            //existing.Password = user.Password;
            //existing.IsActive= true;

            //_dbContext.SaveChanges();

            //var existing = Users.FirstOrDefault(x => x.Id == user.Id);
            //if (existing == null)
            //    return;
            //existing.Login = user.Login;
            //existing.Password = user.Password;
            //existing.FullName = user.FullName;
            //existing.FullName = user.FullName;
            //existing.IsActive = user.IsActive;
            //existing.IsAdmin = user.IsAdmin;
        }

        public void DeleteFile(int id)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            //if (existing == null)
            //    return;

            //_dbContext.Users.Remove(existing);
            //_dbContext.Persons.Remove(person);

            //_dbContext.SaveChanges();

            var existing = Files.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Files.Remove(existing);
        }

    }
}
