using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RD.Models;

namespace RD.Services
{
    public class CounterpartiesService
    {

        public static List<Counterparty> Counterparties = new List<Counterparty>
        {
                new Counterparty(1, "Петров И. Н.")
        };

        public IEnumerable<Counterparty> GetCounterparties()
        {
            return Counterparties;
            //return _dbContext.Users.ToArray();
        }

        public bool AddCounterparty(Counterparty counterparty)
        {
            if (Counterparties.Any(x => x.Name == counterparty.Name))
                return false;

            if (Counterparties.Count() < 1 || Counterparties == null)
                counterparty.Id = 1;
            else
            {
                int LastId = Counterparties.Max(user => user.Id);
                counterparty.Id = LastId + 1;
            }

            Counterparties.Add(counterparty);

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

        public void UpdateCounterparty(Counterparty counterparty)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            //if (existing == null)
            //    return;

            //existing.Login = user.Login;
            //existing.Password = user.Password;
            //existing.IsActive= true;

            //_dbContext.SaveChanges();

            var existing = Counterparties.FirstOrDefault(x => x.Id == counterparty.Id);
            if (existing == null)
                return;

            existing.Name = counterparty.Name;

        }

        public void DeleteCounterparty(int id)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            //if (existing == null)
            //    return;

            //_dbContext.Users.Remove(existing);
            //_dbContext.Persons.Remove(person);

            //_dbContext.SaveChanges();

            var existing = Counterparties.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Counterparties.Remove(existing);
        }


        //public bool ChangeLogin(string oldLogin, string newLogin)
        //{
        //    //var existing = _dbContext.Users.FirstOrDefault(x => x.Login == newLogin);
        //    //var user = _dbContext.Users.FirstOrDefault(x => x.Login == oldLogin);
        //    //var person = _dbContext.Persons.FirstOrDefault(x => x.Login == oldLogin);

        //    //if (existing != null)
        //    //    return false;

        //    //user.Login = newLogin;
        //    //person.Login = newLogin;

        //    //_dbContext.SaveChanges();

        //    var existing = Users.FirstOrDefault(x => x.Login == oldLogin);
        //    if (existing != null)

        //        existing.Login = newLogin;

        //    return true;

        //}



    }
}
