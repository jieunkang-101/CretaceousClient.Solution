using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CretaceousClient.Models;

namespace CretaceousClient.Controllers
{
  public class AnimalsController : Controller
  {
    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return View(allAnimals);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Animal animal)
    {
      Animal.Post(animal);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var animal = Animal.GetDetails(id);
      return View(animal);
    }

    public IActionResult Edit(int id)
    {
      var animal = Animal.GetDetails(id);
      return View(animal);
    }

    [HttpPost]
    public IActionResult Edit(int id, Animal animal)
    {
      animal.AnimalId = id;
      Animal.Put(animal);
      return RedirectToAction("Index");
    }

    // [HttpPost]
    // public IActionResult Details(int id, Animal animal)
    // {
    //   animal.AnimalId = id;
    //   Animal.Put(animal);
    //   return RedirectToAction("Details", id);
    // }


    public IActionResult Delete(int id)
    {
      Animal.Delete(id);
      return RedirectToAction("Index");
    }
  }
}            
        