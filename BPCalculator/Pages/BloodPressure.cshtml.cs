using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// page model

namespace BPCalculator.Pages
{
    public class BloodPressureModel : PageModel
    {
        [BindProperty]                              // bound on POST
        public BloodPressure BP { get; set; }

        // setup initial data
        public void OnGet()
        {
            BP = new BloodPressure() { Systolic = 100, Diastolic = 60, Age = 24 };
        }

        // POST, validate
        public IActionResult OnPost()
        {
            // extra validation
            if (!(BP.Systolic > BP.Diastolic))
            {
                ModelState.AddModelError("", "Systolic must be greater than Diastolic");
            }
            if (BP.Age < 1 || BP.Age > 120)
            {
                ModelState.AddModelError("", "Age Must be between the ages of 1 and 120 years");
            }
            return Page();
        }
    }
}