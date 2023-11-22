using DTOs;
using Entities;
using Microsoft.AspNetCore.Identity;
using Repositories.Interfaces;

namespace Repositories.Implements
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<UserModel> CreateUser(CreateUserModel model,string password)
        {
            var user = model.ParseToEntity();
            
            await _userManager.CreateAsync(user,"132");
            return new UserModel(user);
        }

        public Task<UserModel> FindUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> UpdateUser(UpdateUserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
