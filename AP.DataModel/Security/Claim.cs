using System;
using System.Collections.Generic;
using System.Text;

namespace AP.DataModel.Security
{
    public class Claim: AbstractModel
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
