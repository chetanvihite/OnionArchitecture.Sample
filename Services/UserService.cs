
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _repository.GetUsers();
        }
    }
}
