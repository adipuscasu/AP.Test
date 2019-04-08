using System;
using System.Collections.Generic;
using System.Text;

namespace AP.DataModel.Security
{
    public class UserRole: AbstractModel
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
