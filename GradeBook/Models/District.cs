using GradeBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class District : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<School> Schools { get; set; }
    }
}
