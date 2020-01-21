using Microsoft.AspNetCore.Mvc;
using Physician.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Physician.Controllers
{
  public class PatientsController : Controller
  {
    private readonly PhysicianContext _db;

    public PatientsController(PhysicianContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    { 
        return View(_db.Patients.ToList());
    }
    
    [HttpPost]
    public ActionResult Create(Patient patient)
    {
      _db.Patients.Add(patient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Create()
    {
      return View();
    }

    public ActionResult Details(int id)
    {
      Patient thisPatient = _db.Patients.FirstOrDefault(patients => patients.PatientId == id);
      return View(thisPatient);
    }
  }
}