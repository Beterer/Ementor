using Ementor.EntityFramework;

namespace Ementor.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly EmentorDbContext _context;

        public InitialDataBuilder(EmentorDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
        }
    }
}
