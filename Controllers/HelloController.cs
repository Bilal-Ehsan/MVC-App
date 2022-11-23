using App.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

public class HelloController : Controller
{
    private static List<DogViewModel> dogs = new List<DogViewModel>();

    public IActionResult Index()
    {
        // var dog = new DogViewModel { Name = "Penis", Age = 3 };
        return View(dogs);
    }

    public IActionResult Create()
    {
        var dog = new DogViewModel();
        return View(dog);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        // return View("Index");
        dogs.Add(dogViewModel);
        return RedirectToAction(nameof(Index)); 
    }
}
