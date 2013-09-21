
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}
