namespace Stock.DAL.Infrastructure.Abstract
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
