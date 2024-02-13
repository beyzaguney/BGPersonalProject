using BusinessLayer.Services;
using DataLayer.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Content;

public class PortfolioManager:IGenericService<Portfolio>,IPortfolioService
{
    private readonly IPortfolioDal _workDal;
    public PortfolioManager (IPortfolioDal workDal) 
    {
        _workDal = workDal; 
    }

    public List<Portfolio> GetList()
    {
        return _workDal.GetList();
    }

    public void TAdd(Portfolio t)
    {
        _workDal.Add(t);
    }

    public void TDelete(Portfolio t)
    {
        _workDal.Delete(t);
    }

    public Portfolio TGetById(int id)
    {
        return _workDal.GetById(id);
    }

    public void TUpdate(Portfolio t)
    {
        _workDal.Update(t);
    }
}
