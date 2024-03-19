using Comic_Api.Models.DB;
using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index([FromForm] string email, string password)
        {
            UserDB db = new UserDB();
            var user = db.GetAllUsers();
            String error ="" ;
            foreach (var u in user)
            {
                if (u.Email == email)
                {
                    if (u.VerifyPassword(password))
                    {
                        return View("Result", u);
                    }
                    else
                    { 
                        error = "Wachtwoord is verkeerd";
                        //wachtwoord is verkeerd
                    }
                }
                else
                {
                    if(error == "")
                    {
                    error = "Email niet gekend";
                    }
                    //Email niet gekend
                }
                
            }

            return View("Index", error);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SignUp(User u, String password)
        {
            u.HashPassword(password);
            UserDB userDB = new UserDB();
            userDB.AddUser(u);
            return View("Result",u);
        }
    }
}
