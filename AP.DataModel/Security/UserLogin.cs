using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AP.DataModel.Security
{
    public class UserLogin: AbstractModel
    {
        [MaxLength(128)] public string LoginProvider { get; set; }
        [MaxLength(128)] public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public User User { get; set; }
    }
}
