using TesteStefanini.Cadastros.Dominios.Interfaces.UoW;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

namespace TesteStefanini.Cadastros.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbStefanini _context;

        public UnitOfWork(DbStefanini context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
