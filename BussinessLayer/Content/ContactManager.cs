using BusinessLayer.Services;
using DataLayer.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Content;

public class ContactManager:IGenericService<Contact>,IContactService
{
    private readonly IContactDal _contactDal;
    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public List<Contact> GetList()
    {
        return _contactDal.GetList();
    }

    public void TAdd(Contact t)
    {
        _contactDal.Add(t);
    }

    public void TDelete(Contact t)
    {
        _contactDal.Delete(t);
    }

    public Contact TGetById(int id)
    {
        return _contactDal.GetById(id);
    }

    public void TUpdate(Contact t)
    {
        _contactDal.Update(t);
    }
}
