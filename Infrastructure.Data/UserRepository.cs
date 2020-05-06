
using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetUsers()
        {
            // in reality you would connet to Database from this point, but for demo purposes
            // we will just return in-memory data
            var users = new List<User>()
                {
                    new User { DateCreated = DateTime.Now, Email = "jlechem@gmail.com", FirstName = "Justin", LastName = "LeCheminant"},
                };

            return users;
        }
    }
}
