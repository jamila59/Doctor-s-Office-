using Microsoft.AspNetCore.Mvc;
using Physician.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Physician.Controllers
{
  public class DoctorsController : Controller
  {
    private readonly PhysicianContext _db;

    public DoctorsController(PhysicianContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    { 
        return View(_db.Doctors.ToList());
    }
    
    [HttpPost]
    public ActionResult Create(Doctor doctor)
    {
      _db.Doctors.Add(doctor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Create()
    {
      return View();
    }

    public ActionResult Details(int id)
    {
      Doctor thisDoctor = _db.Doctors.FirstOrDefault(doctors => doctors.DoctorId == id);
      return View(thisDoctor);
    }
  }
}