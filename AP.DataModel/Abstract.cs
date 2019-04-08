using System;
using System.ComponentModel.DataAnnotations;

namespace AP.DataModel
{
    public class AbstractModel
    {
        [Required]
        public int Id { get; set; }

    }
}
