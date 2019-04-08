using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;

namespace AP.DataModel.Security
{
    public class User: AbstractModel, IUser
    {
        public User()
        {
            
        }

        public User(string userName): this()
        {
            UserName = userName;
        }

        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        string IUser<string>.Id => throw new NotImplementedException();
    }
}
