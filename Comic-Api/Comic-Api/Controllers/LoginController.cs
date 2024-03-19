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
                        HttpContext.Response.Cookies.Append("UserID", u.UserID.ToString());
                        //return View("Result", u);
                        return RedirectToAction("Result");
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

            if (!login(u.Email,password).Equals(""))
            {
                userDB.AddUser(u);
                login(u.Email, password);
                //  return View("Result",u);
                return RedirectToAction("Result");
            }
            //Account bestaat all
            ViewBag.Error = "Email has already used, Choose a new one!";
            return View("SignUp");
        }

        private String login(string email, string password)
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
                        //Ingelogd
                        HttpContext.Response.Cookies.Append("UserID", u.UserID.ToString());
                        error = "";
                        return error;
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
            return error;
        }


        private int? GetUserIDFromCookies()
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserID", out string userId))
            {
                if (int.TryParse(userId, out int id))
                {
                    return id;
                }
            }
            return null; 
        }

        public IActionResult Result()
        {
            int? userId = GetUserIDFromCookies();

            if (userId.HasValue)
            {
                UserDB db = new UserDB();
                var user = db.GetUserByID(userId.Value);

                if (user != null)
                {
                    return View(user);
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("UserID");

            return RedirectToAction("Index", "Home");
        }






    }
}
