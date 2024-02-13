using DataLayer.Abstract;
using DataLayer.Repository;
using Model;

namespace DataLayer.EfCore;

public class EfSkill:GenericRepository<Skill>,ISkillDal
{
    public EfSkill(AppDbContext dbContext) : base(dbContext) { }
}
