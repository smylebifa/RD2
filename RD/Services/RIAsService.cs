using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public class RIAsService
    {
        public static List<RIA> RIAs = new List<RIA>
        {
                new RIA(1, "", "", "Иванов", "Москва"),
        };

        public IEnumerable<RIA> GetRIAs()
        {
            return RIAs;
            //return _dbContext.Users.ToArray();
        }

        public void AddRIA(RIA ria)
        {
            if (RIAs.Any(x => x.Id == ria.Id))
                throw new ArgumentException("User with such login already exists.");

            int LastId = RIAs.Max(user => user.Id);
            if (LastId is int)
            {
                ria.Id = LastId + 1;
                
                RIAs.Add(ria);
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

        public void UpdateRIA(RIA ria)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            //if (existing == null)
            //    return;

            //existing.Login = user.Login;
            //existing.Password = user.Password;
            //existing.IsActive= true;

            //_dbContext.SaveChanges();

            var existing = RIAs.FirstOrDefault(x => x.Id == ria.Id);
            if (existing == null)
                return;
            existing.Authors = ria.Authors;
            existing.Location = ria.Location;
            existing.Props = ria.Props;
            existing.Result = ria.Result;
            existing.StageId = ria.StageId;
        }

        public void DeleteRIA(int id)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            //if (existing == null)
            //    return;

            //_dbContext.Users.Remove(existing);
            //_dbContext.Persons.Remove(person);

            //_dbContext.SaveChanges();

            var existing = RIAs.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            RIAs.Remove(existing);
        }

    }
}
