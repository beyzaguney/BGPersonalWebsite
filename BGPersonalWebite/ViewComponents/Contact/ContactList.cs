using BGPersonalWebsite.ViewComponents.About;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace BGPersonalWebsite.ViewComponents.Contact;

public class ContactList:ViewComponent
{
    private readonly IContactService _contactService;
    public ContactList(IContactService contactService)
    {
        _contactService=contactService;
    }
    public IViewComponentResult Invoke()
    {
        var values = _contactService.GetList();
        return View(values);
    }
}
