using DataLayer.Abstract;
using DataLayer.Repository;
using Model;

namespace DataLayer.EfCore;

public class EfMessage:GenericRepository<Message>,IMessageDal
{
    public EfMessage(AppDbContext dbContext):base(dbContext) { }
}
