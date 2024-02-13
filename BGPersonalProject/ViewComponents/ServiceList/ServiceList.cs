using Microsoft.AspNetCore.Mvc;

namespace BGPersonalProject.ViewComponents.ServiceList;

public class ServiceList:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
