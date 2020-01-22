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
    public ActionResult Create(Patient patient, int DoctorId)
    {
    _db.Patients.Add(patient);
    if (DoctorId != 0)
      {
          _db.DoctorPatient.Add(new DoctorPatient() { DoctorId = DoctorId, PatientId = patient.PatientId });
      }
    _db.SaveChanges();
    return RedirectToAction("Index");
    }

    public ActionResult Create()
    {
      return View();
    }

    public ActionResult Details(int id)
    {
      var thisPatient = _db.Patients
        .Include(patient => patient.Doctors)
        .ThenInclude(join => join.Doctor)
        .FirstOrDefault(patient => patient.PatientId == id);
      return View(thisPatient);
    }
  }
}