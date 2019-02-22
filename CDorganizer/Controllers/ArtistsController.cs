using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CDorganizer.Models;

namespace CDorganizer.Controllers
{
  public class ArtistsController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artists> allArtists = Artists.GetAll();
      return View(allArtists);
    }
    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artists newArtist = new Artists(artistName);
      List<Artists> allArtists = Artists.GetAll();
      return View("Index", allArtists);
    }
    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artists selectedArtists = Artists.Find(id);
      List<CD> artistCDs = selectedArtists.GetCDs();
      model.Add("artists", selectedArtists);
      model.Add("CD", artistCDs);
      return View(model);
    }
  }
}
