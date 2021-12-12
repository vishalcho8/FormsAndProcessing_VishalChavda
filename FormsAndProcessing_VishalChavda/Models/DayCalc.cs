using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndProcessing_VishalChavda.Models
{
    public class DayCalc
    {
        [Display(Name = "Select Date"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Add Days")]
        public int Day { get; set; }

        [Display(Name = "New Date (Result)")]
        public String NewDate { get; set; }
    }
}
