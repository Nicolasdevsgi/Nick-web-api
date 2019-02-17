using Nick.Web.Infra.Data.Context;

namespace Nick.Web.Infra.Data.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NickWebContext _context;

        public UnitOfWork(NickWebContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
