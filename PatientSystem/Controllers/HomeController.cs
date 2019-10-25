using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PatientSystem.Controllers
{
    public class HomeController : Controller
    {
        public static Models.Patient p1 = new Models.Patient
        {
            Name = "Hassan Shabbir",
            Age = 22,
            Address = "2357 Usman Road",
            Occupation = "Programmer",
            HasInsurance = true,
            HadPreviousOperation = true,
            MaritialStatus = "Single"
        };

        public static Models.Patient p2 = new Models.Patient
        {
            Name = "Kan Jiang",
            Age = 21,
             Address = "847 Jaywin Circle",
            Occupation = "Programmer",
            HasInsurance = true,
            HadPreviousOperation = false,
            MaritialStatus = "Single"
        };

        public List<Models.Patient> patients = new List<Models.Patient> { p1, p2 };
        public IActionResult Index()
        {
            return View(p1);
        }

        [HttpGet]
        public IActionResult PatientRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(PatientSystem.Models.Patient patient)
        {
            patients.Add(patient);
            return View();
        }

        public IActionResult ListPatients()
        {
            foreach (Models.Patient p in patients)
            {
                Console.WriteLine("hi");
            }
            return View(patients.OrderBy(p => p.Name));
        }
    }
}