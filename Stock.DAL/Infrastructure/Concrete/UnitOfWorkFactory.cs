namespace Stock.DAL.Infrastructure.Concrete
{
    using Abstract;

    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new UnitOfWork();
        }
    }
}
