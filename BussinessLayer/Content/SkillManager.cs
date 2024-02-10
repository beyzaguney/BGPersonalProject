using BusinessLayer.Services;
using DataLayer.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Content;

public class SkillManager:IGenericService<Skill>,ISkillService
{
    private readonly ISkillDal _skillDal;
    public SkillManager(ISkillDal skillDal)
    {
        _skillDal = skillDal;
    }

    public List<Skill> GetList()
    {
        return _skillDal.GetList();
    }

    public void TAdd(Skill t)
    {
        _skillDal.Add(t);
    }

    public void TDelete(Skill t)
    {
        _skillDal.Delete(t);
    }

    public Skill TGetById(int id)
    {
        return _skillDal.GetById(id);
    }

    public void TUpdate(Skill t)
    {
        _skillDal.Update(t);
    }
}
