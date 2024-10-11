using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Webgentle";
        }
    }
}
