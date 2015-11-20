using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Ementor.Users;
using Ementor.Atendeees;

namespace Ementor.Classes
{
    public class Class : Entity
    {
        public virtual ClassCategory Category { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual ClassStatus Status { get; set; }
    }
}
