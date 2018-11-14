using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name="Low Blood Pressure")] Low,
        [Display(Name="Normal Blood Pressure")]  Normal,
        [Display(Name="Pre-High Blood Pressure")] PreHigh,
        [Display(Name ="High Blood Pressure")]  High,
        [Display(Name = "Unknown Blood Pressure")] Unknown,
        [Display(Name = "Exception")] Exception
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;


        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG


        // calculate BP category
        public BPCategory Category
        {       
          
            get
            {
                try
                {
                    int systolicValue = int.Parse(Systolic.ToString());
                    int diastolicValue = int.Parse(Diastolic.ToString());

                    if ((systolicValue >= 70 && systolicValue <= 90) && (diastolicValue >= 40 && diastolicValue <= 60))
                    {
                        return BPCategory.Low;
                    }
                    if ((systolicValue >= 90 && systolicValue <= 120) && (diastolicValue >= 60 && diastolicValue <= 80))
                    {
                        return BPCategory.Normal;
                    }
                    if ((systolicValue >= 120 && systolicValue <= 140) && (diastolicValue >= 80 && diastolicValue <= 90))
                    {
                        return BPCategory.PreHigh;
                    }
                    if ((systolicValue >= 140 && systolicValue <= 190) && (diastolicValue >= 90 && diastolicValue <= 100))
                    {
                        return BPCategory.High;
                    }
                } catch (Exception) {  return BPCategory.Exception; }
                return BPCategory.Unknown;
            }
        }
    }
}
