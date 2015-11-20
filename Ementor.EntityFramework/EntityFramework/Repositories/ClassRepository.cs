using Abp.EntityFramework;
using Ementor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ementor.EntityFramework.Repositories
{
    public class ClassRepository : EmentorRepositoryBase<Class, int>, IClassRepository
    {
        public ClassRepository(IDbContextProvider<EmentorDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public List<Class> GetAllClasses()
        {
            var query = GetAll();

            query = query.Where(clas => clas.Id != null);

            return query.ToList();
        }
    }
}
