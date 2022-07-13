using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class User
    {
        private string v1;
        private int v2;

        public User(Guid id, string userName, string v1, int v2)
        {
            Id = id;
            UserName = userName;
            this.v1 = v1;
            this.v2 = v2;
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }       
    }
}
