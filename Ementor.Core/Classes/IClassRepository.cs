using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ementor.Classes
{
    public interface IClassRepository : IRepository<Class, int>
    {
        List<Class> GetAllClasses();
    }
}
