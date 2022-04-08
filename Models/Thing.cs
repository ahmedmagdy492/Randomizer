using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Models
{
    public class Thing
    {
        public Thing()
        {
            ID = Guid.NewGuid().ToString("N");
        }

        [Key]
        public string? ID { get; set; }
        public string? Content { get; set; }
    }
}
