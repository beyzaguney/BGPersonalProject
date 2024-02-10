using BusinessLayer.Services;
using DataLayer.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Content;

public class MessageManager : IGenericService<Message>, IMessageService
{
    public IMessageDal _messageDal;
    public MessageManager(IMessageDal messageDal)
    {
        _messageDal = messageDal;
    }
    public List<Message> GetList()
    {
        return _messageDal.GetList();
    }

    public void TAdd(Message t)
    {
        _messageDal.Add(t);
    }

    public void TDelete(Message t)
    {
        _messageDal.Delete(t);
    }

    public Message TGetById(int id)
    {
        return _messageDal.GetById(id);
    }

    public void TUpdate(Message t)
    {
        _messageDal.Update(t);
    }
}
