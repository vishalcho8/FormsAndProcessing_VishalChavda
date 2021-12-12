using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormsAndProcessing_VishalChavda.Models;

namespace FormsAndProcessing_VishalChavda.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [FromForm]
        public DayCalc DayCalc { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
             
        }

        public void OnPost()
        {
           var x = DayCalc.Date.AddDays(DayCalc.Day);
           DayCalc.NewDate = x.ToString("yyyy-MM-dd");


        }
    }
}
