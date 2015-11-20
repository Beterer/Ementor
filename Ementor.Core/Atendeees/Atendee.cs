using Abp.Domain.Entities;
using Ementor.Classes;
using Ementor.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ementor.Atendeees
{
    public class Atendee : Entity
    {
        public virtual User User { get; set; }
        public virtual Class Class { get; set; }
        public virtual AtendeeType Type { get; set; }
    }
}
