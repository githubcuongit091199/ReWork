using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarUrl { get; set; }
        public UserModel() { }
        public UserModel(User user) { 
            UserName = user.UserName;
            Email = user.Email;
            FirstName = user.FirstName;
            LastName = user.LastName;
            AvatarUrl = user.AvatarUrl;
        }
    }
    public class CreateUserModel
    {
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string AvatarUrl { get; set; }
        public User ParseToEntity()
        {
            return new User
            {
                UserName = UserName,
                PasswordHash = Password,
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                AvatarUrl = AvatarUrl
            };
        }

    }
    public class UpdateUserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarUrl { get; set; }
    }
}
