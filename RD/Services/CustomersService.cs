using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public class CustomersService
    {

           public static List<Customer> Customers = new List<Customer>
        {
                new Customer(1, "Иванов И. Н.")
        };

            public IEnumerable<Customer> GetCustomers()
            {
                return Customers;
                //return _dbContext.Users.ToArray();
            }

            public void AddCustomer(Customer customer)
            {
                if (Customers.Any(x => x.Name == customer.Name))
                    throw new ArgumentException("User with such login already exists.");

                int LastId = Customers.Max(user => user.Id);
                if (LastId is int)
                {
                    customer.Id = LastId + 1;

                    Customers.Add(customer);
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

            public void UpdateCustomer(Customer customer)
            {
                //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

                //if (existing == null)
                //    return;

                //existing.Login = user.Login;
                //existing.Password = user.Password;
                //existing.IsActive= true;

                //_dbContext.SaveChanges();

                var existing = Customers.FirstOrDefault(x => x.Id == customer.Id);
                if (existing == null)
                    return;
                
                existing.Name = customer.Name;
                
            }

            public void DeleteCustomer(int id)
            {
                //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
                //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

                //if (existing == null)
                //    return;

                //_dbContext.Users.Remove(existing);
                //_dbContext.Persons.Remove(person);

                //_dbContext.SaveChanges();

                var existing = Customers.FirstOrDefault(x => x.Id == id);
                if (existing == null)
                    return;
                Customers.Remove(existing);
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
