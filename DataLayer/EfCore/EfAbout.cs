using DataLayer.Abstract;
using DataLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfCore
{
    public class EfAbout : GenericRepository<About>, IAboutDal
    {
        public EfAbout(AppDbContext appDbContext) : base(appDbContext)
        {
        }

   
    }
}
