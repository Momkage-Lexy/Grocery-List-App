using Microsoft.AspNetCore.Mvc;
using HW3Project.Models;
using System.Diagnostics;

namespace HW3Project.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        Debug.WriteLine("In the index method");
        return View();
    }

    [HttpPost]
    public IActionResult AddItem(Item item)
    {

        if (ModelState.IsValid)
        {
            Repository.AddItem(item);
            ModelState.Clear();
            // Redirect back to the Index view on successful addition.
            return View("Index");
        }
        else
        {
            // Return to the Index view with the submitted item data for correction.
            return View("Index", item);
        }
    }
}
