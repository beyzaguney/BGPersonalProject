using BusinessLayer.Services;
using DataLayer.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Content;

public class SocialMediaManager:IGenericService<SocialMedia>,ISocialMediaService
{
    private readonly ISocialMediaDal _socialMediaDal;
    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public List<SocialMedia> GetList()
    {
        return _socialMediaDal.GetList();
    }

    public void TAdd(SocialMedia t)
    {
        _socialMediaDal.Add(t);
    }

    public void TDelete(SocialMedia t)
    {
        _socialMediaDal.Delete(t);
    }

    public SocialMedia TGetById(int id)
    {
        return _socialMediaDal.GetById(id);
    }

    public void TUpdate(SocialMedia t)
    {
        _socialMediaDal.Update(t);
    }
}
