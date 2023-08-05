using Microsoft.AspNetCore.Mvc;

namespace ProniaMVC.Areas.ProniaAdmin.Controllers;

[Area("proniaadmin")]
public class DashboardController : Controller
{
    public string Index()
    {
        return "Hello from Dashboard";
    }
}
