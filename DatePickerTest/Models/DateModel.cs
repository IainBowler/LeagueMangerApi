using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DatePickerTest.Models
{
    public class DateModel
    {
        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public Nullable<DateTime> DOB { get; set; }

    }
}