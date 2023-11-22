using DTOs;
using Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IUserService
    {
        Task<UserModel> CreateUser(CreateUserModel model, string password);
        Task<UserModel> FindUserByEmail(string email);
        Task<UserModel> UpdateUser(UpdateUserModel model);
    }
}
