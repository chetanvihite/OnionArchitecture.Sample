
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
                    new User { DateCreated = DateTime.Now, Email = "chetan.vihite@thedigitalgroup.net", FirstName = "chetan", LastName = "vihite"},
                    new User { DateCreated = DateTime.Now, Email = "sunil.sahoo@thedigitalgroup.net", FirstName = "sunil", LastName = "sahoo"},
                    new User { DateCreated = DateTime.Now, Email = "shashikant.patil@thedigitalgroup.net", FirstName = "shashikant", LastName = "patil"},
                    new User { DateCreated = DateTime.Now, Email = "sushseel.kumar@thedigitalgroup.net", FirstName = "susheel", LastName = "kumar"},
                    new User { DateCreated = DateTime.Now, Email = "jagdeep.singh@thedigitalgroup.net", FirstName = "jagdeep", LastName = "khalsa"},
                };

            return users;
        }
    }
}
