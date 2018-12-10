using System;
using System.ComponentModel.DataAnnotations;
namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name = "Low Blood Pressure General")] Low,
        [Display(Name = "Low Blood Pressure Baby Age Range")] LowBaby,
        [Display(Name = "Low Blood Pressure Toddler Age Range")] LowToddler,
        [Display(Name = "Low Blood Pressure Child Age Range")] LowChild,
        [Display(Name = "Low Blood Pressure Teen Age Range")] LowTeen,
        [Display(Name = "Low Blood Pressure Adult Age Range")] LowAdult,
        [Display(Name = "Low Blood Pressure MidLife Age Range")] LowMidLife,
        [Display(Name = "Low Blood Pressure Senior Age Range")] LowSenior,


        [Display(Name = "Normal Blood Pressure General")] Normal,
        [Display(Name = "Normal Blood Pressure Baby Age Range")] NormalBaby,
        [Display(Name = "Normal Blood Pressure Toddler Age Range")] NormalToddler,
        [Display(Name = "Normal Blood Pressure Child Age Range")] NormalChild,
        [Display(Name = "Normal Blood Pressure Teen Age Range")] NormalTeen,
        [Display(Name = "Normal Blood Pressure Adult Age Range")] NormalAdult,
        [Display(Name = "Normal Blood Pressure MidLife Age Range")] NormalMidLife,
        [Display(Name = "Normal Blood Pressure Senior Age Range")] NormalSenior,

        [Display(Name = "Pre-High Blood Pressure General")] PreHigh,

        [Display(Name = "High Blood Pressure General")] High,
        [Display(Name = "High Blood Pressure Baby Age Range")] HighBaby,
        [Display(Name = "High Blood Pressure Toddler Age Range")] HighToddler,
        [Display(Name = "High Blood Pressure Child Age Range")] HighChild,
        [Display(Name = "High Blood Pressure Teen Age Range")] HighTeen,
        [Display(Name = "High Blood Pressure Adult Age Range")] HighAdult,
        [Display(Name = "High Blood Pressure MidLife Age Range")] HighMidLife,
        [Display(Name = "High Blood Pressure Senior Age Range")] HighSenior,
        [Display(Name = "Unknown Blood Pressure")] Unknown,
        [Display(Name = "Exception")] Exception
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;
        public const int AgeMin = 0;
        public const int AgeMax = 64;
        
        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG

        [Range(AgeMin, AgeMax, ErrorMessage = "Invalid Age Value")]
        public int Age { get; set; }                       // years

        public string getAgeRange(int Age)
        {

            int ageValue = int.Parse(Age.ToString());

            if (ageValue >= 1 && ageValue <= 1)
            {
                return "baby";
            }
            if (ageValue >= 2 && ageValue <= 5)
            {
                return "toddler";
            }
            if (ageValue >= 6 && ageValue <= 13)
            {
                return "child";
            }
            if (ageValue >= 14 && ageValue <= 19)
            {
                return "teen";
            }
            if (ageValue >= 20 && ageValue <= 39)
            {
                return "adult";
            }
            if (ageValue >= 40 && ageValue <= 59)
            {
                return "midlife";
            }
            if (ageValue >= 64 && ageValue <= 120)
            {
                return "senior";
            }
            return "Unsupported Age";
        }

        public BPCategory getLowResult(int systolicValue, int diastolicValue, string ageRange)
        {
            if (ageRange == "baby" && systolicValue == 75 && diastolicValue == 50)
            {
                return BPCategory.LowBaby;
            }
            if (ageRange == "toddler" && systolicValue == 80 && diastolicValue == 55)
            {
                return BPCategory.LowToddler;
            }
            if (ageRange == "child" && systolicValue == 90 && diastolicValue == 60)
            {
                return BPCategory.LowChild;
            }
            if (ageRange == "teen" && systolicValue == 105 && diastolicValue == 73)
            {
                return BPCategory.LowTeen;
            }
            if (ageRange == "adult" && systolicValue >= 108 && systolicValue <= 111 && diastolicValue >= 75 && diastolicValue <= 78)
            {
                return BPCategory.LowAdult;
            }
            if (ageRange == "midlife" && systolicValue >= 112 && systolicValue <= 118 && diastolicValue >= 79 && diastolicValue <= 82)
            {
                return BPCategory.LowMidLife;
            }
            if (ageRange == "senior" && systolicValue == 121 && diastolicValue == 83)
            {
                return BPCategory.LowSenior;
            }
            return BPCategory.Low;
        }

        public BPCategory getNormalResult(int systolicValue, int diastolicValue, string ageRange)
        {
            if (ageRange == "baby" && systolicValue == 90 && diastolicValue == 60)
            {
                return BPCategory.NormalBaby;
            }
            if (ageRange == "toddler" && systolicValue == 95 && diastolicValue == 65)
            {
                return BPCategory.NormalToddler;
            }
            if (ageRange == "child" && systolicValue == 105 && diastolicValue == 70)
            {
                return BPCategory.NormalChild;
            }
            if (ageRange == "teen" && systolicValue == 117 && diastolicValue == 77)
            {
                return BPCategory.NormalTeen;
            }
            if ((ageRange == "adult") && (systolicValue >= 120 && systolicValue <= 123) && (diastolicValue >= 79 && diastolicValue <= 82))
            {
                return BPCategory.NormalAdult;
            }
            if ((ageRange == "midlife") && (systolicValue >= 125 && systolicValue <= 131) && (diastolicValue >= 83 && diastolicValue <= 86))
            {
                return BPCategory.NormalMidLife;
            }
            if (ageRange == "senior" && systolicValue == 134 && diastolicValue == 87)
            {
                return BPCategory.NormalSenior;
            }
            return BPCategory.Normal;
        }

        public BPCategory getHighResult(int systolicValue, int diastolicValue, string ageRange)
        {
            if (ageRange == "baby" && systolicValue == 110 && diastolicValue == 75)
            {
                return BPCategory.HighBaby;
            }
            if (ageRange == "toddler" && systolicValue == 110 && diastolicValue == 79)
            {
                return BPCategory.HighToddler;
            }
            if (ageRange == "child" && systolicValue == 115 && diastolicValue == 80)
            {
                return BPCategory.HighChild;
            }
            if (ageRange == "teen" && systolicValue == 120 && diastolicValue == 81)
            {
                return BPCategory.HighTeen;
            }
            if (ageRange == "adult" && systolicValue >= 132 && systolicValue <= 135 && diastolicValue >= 83 && diastolicValue <= 86)
            {
                return BPCategory.HighAdult;
            }
            if (ageRange == "midlife" && systolicValue >= 137 && systolicValue <= 144 && diastolicValue >= 87 && diastolicValue <= 90)
            {
                return BPCategory.HighMidLife;
            }
            if (ageRange == "senior" && systolicValue == 147 && diastolicValue == 91)
            {
                return BPCategory.HighSenior;
            }
            return BPCategory.High;
        }

        // calculate BP category
        public BPCategory Category
        {
            get
            {
                // TODO: Need to include proper exception handling
                try
                {
                    int systolicValue = int.Parse(Systolic.ToString());
                    int diastolicValue = int.Parse(Diastolic.ToString());
                    int ageValue = int.Parse(Age.ToString());
                    string ageRange = getAgeRange(Age);

                    if ((systolicValue >= 70 && systolicValue <= 90) && (diastolicValue >= 40 && diastolicValue <= 60))
                    {
                        return getLowResult(systolicValue, diastolicValue, ageRange);
                    }
                    if ((systolicValue >= 90 && systolicValue <= 120) && (diastolicValue >= 60 && diastolicValue <= 80))
                    {
                        return getNormalResult(systolicValue, diastolicValue, ageRange);
                    }
                    if ((systolicValue >= 120 && systolicValue <= 140) && (diastolicValue >= 80 && diastolicValue <= 90))
                    {
                        return BPCategory.PreHigh;
                    }
                    if ((systolicValue >= 140 && systolicValue <= 190) && (diastolicValue >= 90 && diastolicValue <= 100))
                    {
                        return getHighResult(systolicValue, diastolicValue, ageRange);
                    }
                }
                catch (Exception) { return BPCategory.Exception; }
                return BPCategory.Unknown;
            }
        }
    }
}
