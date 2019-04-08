using System;
using System.Collections.Generic;
using System.Text;

namespace AP.DataModel.Security
{
    public class RoleClaims: AbstractModel
    {
        public Role Role { get; set; }
        public Claim Claim { get; set; }
    }
}
