using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AP.DataModel.Security
{
    public class UserToken: AbstractModel
    {
        public User User { get; set; }
        [MaxLength(128)] public string LoginProvider { get; set; }
        [MaxLength(128)] public string Name { get; set; }
        public string Value { get; set; }

    }
}
