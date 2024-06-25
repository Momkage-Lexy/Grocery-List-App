using Microsoft.AspNetCore.Mvc;
using HW3Project.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http.Features;

namespace HW3Project.Controllers;

public class GroceriesController : Controller
{
   [HttpGet]
    public ViewResult GroceryListView()
    {
        // Calculate and pass the total item count to the view.
        ViewBag.TotalCount = Repository.GetTotalItemCount();
        // Pass the list of all items to the view.
        return View("GroceryListView", Repository.Items);
    }

    [HttpPost]
    public IActionResult DeleteItems(int[] selectedItems)
    {
   
        foreach (var id in selectedItems)
        {
            // Delete selected item in repository.
            Repository.DeleteItem(id);
        }
        // Redirects to the GroceryListView action in the HomeController.
        return RedirectToAction("GroceryListView", "Groceries");
    }

    [HttpGet]
    public ViewResult UpdateQuantitiesView()
    {
        // Check how many items are in repository
        var total = Repository.GetTotalItemCount();

        // If none do not change view to UpdateQuantities
        if(total != 0)
        {
            return View("UpdateQuantities", Repository.Items);
        }
        else
        {
            return View("GroceryListView", Repository.Items);
        }
    }

    [HttpPost]
    public IActionResult UpdateQuantities(Dictionary<int, int> quantities)
    {
        foreach (var entry in quantities)
        {
            var itemId = entry.Key;
            var newQuantity = entry.Value;
            // Update the quantity of the specified item in the repository.
            Repository.UpdateItemQuantity(itemId, newQuantity);
        }
        // Redirects to GroceryListView action in the HomeController.
        return RedirectToAction("GroceryListView", "Groceries");
    }
}