using BusinessLayer.Services;
using DataLayer.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Content;

public class ServiceManager : IGenericService<Service>, IServiceService
{
    private readonly IServiceDal _serviceDal;
    public ServiceManager(IServiceDal serviceDal)
    {
        _serviceDal = serviceDal;
    }
    public List<Service> GetList()
    {
        return _serviceDal.GetList();
    }

    public void TAdd(Service t)
    {
        _serviceDal.Add(t);
    }

    public void TDelete(Service t)
    {
        _serviceDal.Delete(t);
    }

    public Service TGetById(int id)
    {
        return _serviceDal.GetById(id);
    }

    public void TUpdate(Service t)
    {
        _serviceDal.Update(t);
    }
}
