using Microsoft.AspNetCore.Mvc;
using LibraryWebsite.Models;


public class BookController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult New()
    {
        return View();
    }

    public IActionResult Buy()
    {
        return View ();
    }
}