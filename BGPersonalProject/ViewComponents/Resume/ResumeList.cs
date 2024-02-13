using Microsoft.AspNetCore.Mvc;

namespace BGPersonalProject.ViewComponents.Resume;

public class ResumeList:ViewComponent
{
    public IViewComponentResult Invoke() 
    {
        return View();
    }
}
