using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Ementor.EntityFramework.Repositories
{
    public abstract class EmentorRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<EmentorDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected EmentorRepositoryBase(IDbContextProvider<EmentorDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class EmentorRepositoryBase<TEntity> : EmentorRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected EmentorRepositoryBase(IDbContextProvider<EmentorDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
