using DataLayer.Abstract;
using DataLayer.Repository;
using Model;

namespace DataLayer.EfCore;

public class EfPortfolio : GenericRepository<Portfolio>, IPortfolioDal
{
    public EfPortfolio(AppDbContext dbContext) : base(dbContext) { }
}