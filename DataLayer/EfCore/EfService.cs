using DataLayer.Abstract;
using DataLayer.Repository;
using Model;

namespace DataLayer.EfCore;

public class EfService:GenericRepository<Service>,IServiceDal
{
    public EfService(AppDbContext dbContext):base(dbContext) { }
}
