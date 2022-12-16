using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public class DocsService
    {
        public static List<Doc> Docs = new List<Doc>
        {
                new Doc(1, "Документ 1"),
        };

        public IEnumerable<Doc> GetDocs()
        {
            return Docs;
            //return _dbContext.Users.ToArray();
        }

        public void AddDoc(Doc doc)
        {
            if (Docs.Any(x => x.Id == doc.Id))
                throw new ArgumentException("User with such login already exists.");

            int LastId = Docs.Max(user => user.Id);
            if (LastId is int)
            {
                doc.Id = LastId + 1;

                Docs.Add(doc);
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

        public void UpdateDoc(Doc doc)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            //if (existing == null)
            //    return;

            //existing.Login = user.Login;
            //existing.Password = user.Password;
            //existing.IsActive= true;

            //_dbContext.SaveChanges();

            var existing = Docs.FirstOrDefault(x => x.Id == doc.Id);
            if (existing == null)
                return;
           
            //existing.Authors = doc.Authors;
            //existing.Location = doc.Location;
            //existing.Props = doc.Props;
            //existing.Result = doc.Result;
            //existing.StageId = doc.StageId;
        }

        public void DeleteDoc(int id)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            //if (existing == null)
            //    return;

            //_dbContext.Users.Remove(existing);
            //_dbContext.Persons.Remove(person);

            //_dbContext.SaveChanges();

            var existing = Docs.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Docs.Remove(existing);
        }

    }
}
