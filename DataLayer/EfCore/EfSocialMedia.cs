using DataLayer.Abstract;
using DataLayer.Repository;
using Model;

namespace DataLayer.EfCore;

public class EfSocialMedia : GenericRepository<SocialMedia>, ISocialMediaDal
{
    public EfSocialMedia(AppDbContext dbContext) : base(dbContext) { }
}
