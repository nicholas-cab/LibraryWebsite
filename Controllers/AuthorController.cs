using Microsoft.AspNetCore.Mvc;
using LibraryWebsite.Models;

public class AuthorController : Controller
MySqlConnection con = new MySqlConnection 
{
    public IActionResult Register()
    {
        return View();
    }


[HttpPost]
     public IActionResult Register(string firstName, string lastName, string email, string password)
    {
      try
     {

        var con = this.CreateConnection();
        string cmdText = $"insert into users (fisrtNmae, lastName, email, password) values ('{firstNamer})
        MySqlCommand cmd = new MySqlCommand(cmdText, con);
        cmd.ExecuteNonQuery

        return View();
    }
    
}