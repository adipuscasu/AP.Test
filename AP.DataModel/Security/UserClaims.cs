using System;
using System.Collections.Generic;
using System.Text;

namespace AP.DataModel.Security
{
    public class UserClaims: AbstractModel
    {
        public User User { get; set; }
        public Claim Claim { get; set; }
    }
}
