using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace Ementor.Classes
{
    public class ClassCategory : Entity
    {
        public virtual string Name { get; set; }
        public virtual ClassCategoryDomain Domain { get; set; }
    }
}
