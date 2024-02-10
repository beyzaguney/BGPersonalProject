using BusinessLayer.Services;
using DataLayer.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Content;

public class AboutManager : IGenericService<About>, IAboutService
{
    private readonly IAboutDal _aboutDal;
    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public List<About> GetList()
    {
        return _aboutDal.GetList();
    }

    public void TAdd(About t)
    {
        _aboutDal.Add(t);
    }

    public void TDelete(About t)
    {
        _aboutDal.Delete(t);
    }

    public About TGetById(int id)
    {
        return _aboutDal.GetById(id);
    }

    public void TUpdate(About t)
    {
        _aboutDal.Update(t);
    }
}
