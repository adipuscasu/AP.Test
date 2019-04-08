using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AP.DataModel.Security
{
    public class Role: AbstractModel
    {
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

    }
}
