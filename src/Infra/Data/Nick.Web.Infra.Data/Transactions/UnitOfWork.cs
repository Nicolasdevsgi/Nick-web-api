using Nick.Web.Infra.Data.Context;

namespace Nick.Web.Infra.Data.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NickWebContext _context;

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
