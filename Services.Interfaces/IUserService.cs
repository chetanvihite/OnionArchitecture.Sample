
using System.Collections.Generic;
using Domain.Entities;

namespace Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}
